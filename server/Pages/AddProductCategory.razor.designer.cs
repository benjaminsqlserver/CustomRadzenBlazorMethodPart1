using System;
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
    public partial class AddProductCategoryComponent : ComponentBase
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

        CustomMethodBenjamin.Models.ConData.ProductCategory _productcategory;
        protected CustomMethodBenjamin.Models.ConData.ProductCategory productcategory
        {
            get
            {
                return _productcategory;
            }
            set
            {
                if (!object.Equals(_productcategory, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "productcategory", NewValue = value, OldValue = _productcategory };
                    _productcategory = value;
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
            productcategory = new CustomMethodBenjamin.Models.ConData.ProductCategory(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(CustomMethodBenjamin.Models.ConData.ProductCategory args)
        {
            try
            {
                var conDataCreateProductCategoryResult = await ConData.CreateProductCategory(productcategory);
                DialogService.Close(productcategory);
            }
            catch (System.Exception conDataCreateProductCategoryException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to create new ProductCategory!" });
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
