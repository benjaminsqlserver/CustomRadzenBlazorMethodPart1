﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using CustomMethodBenjamin.Models.ConData;
using Microsoft.EntityFrameworkCore;

namespace CustomMethodBenjamin.Pages
{
    public partial class ProductCategoriesComponent : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        public void Reload()
        {
            InvokeAsync(StateHasChanged);
        }

        public void OnPropertyChanged(PropertyChangedEventArgs args)
        {
        }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected TooltipService TooltipService { get; set; }

        [Inject]
        protected ContextMenuService ContextMenuService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Inject]
        protected ConDataService ConData { get; set; }
        protected RadzenDataGrid<CustomMethodBenjamin.Models.ConData.ProductCategory> grid0;

        string _search;
        protected string search
        {
            get
            {
                return _search;
            }
            set
            {
                if (!object.Equals(_search, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "search", NewValue = value, OldValue = _search };
                    _search = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<CustomMethodBenjamin.Models.ConData.ProductCategory> _getProductCategoriesResult;
        protected IEnumerable<CustomMethodBenjamin.Models.ConData.ProductCategory> getProductCategoriesResult
        {
            get
            {
                return _getProductCategoriesResult;
            }
            set
            {
                if (!object.Equals(_getProductCategoriesResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getProductCategoriesResult", NewValue = value, OldValue = _getProductCategoriesResult };
                    _getProductCategoriesResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Load();
        }
        protected async System.Threading.Tasks.Task Load()
        {
            if (string.IsNullOrEmpty(search)) {
                search = "";
            }

            var conDataGetProductCategoriesResult = await ConData.GetProductCategories(new Query() { Filter = $@"i => i.CategoryName.Contains(@0)", FilterParameters = new object[] { search } });
            getProductCategoriesResult = conDataGetProductCategoriesResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddProductCategory>("Add Product Category", null);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Splitbutton0Click(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await ConData.ExportProductCategoriesToCSV(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}", Expand = "", Select = "CategoryID,CategoryName" }, $"Product Categories");

            }

            if (args == null || args.Value == "xlsx")
            {
                await ConData.ExportProductCategoriesToExcel(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}", Expand = "", Select = "CategoryID,CategoryName" }, $"Product Categories");

            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(CustomMethodBenjamin.Models.ConData.ProductCategory args)
        {
            var dialogResult = await DialogService.OpenAsync<EditProductCategory>("Edit Product Category", new Dictionary<string, object>() { {"CategoryID", args.CategoryID} });
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var conDataDeleteProductCategoryResult = await ConData.DeleteProductCategory(data.CategoryID);
                    if (conDataDeleteProductCategoryResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception conDataDeleteProductCategoryException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to delete ProductCategory" });
            }
        }
    }
}
