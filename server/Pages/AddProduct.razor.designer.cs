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
    public partial class AddProductComponent : ComponentBase
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

        CustomMethodBenjamin.Models.ConData.Product _product;
        protected CustomMethodBenjamin.Models.ConData.Product product
        {
            get
            {
                return _product;
            }
            set
            {
                if (!object.Equals(_product, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "product", NewValue = value, OldValue = _product };
                    _product = value;
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
            var conDataGetProductCategoriesResult = await ConData.GetProductCategories();
            getProductCategoriesResult = conDataGetProductCategoriesResult;

            product = new CustomMethodBenjamin.Models.ConData.Product(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(CustomMethodBenjamin.Models.ConData.Product args)
        {
            try
            {
                var conDataCreateProductResult = await ConData.CreateProduct(product);
                DialogService.Close(product);
            }
            catch (System.Exception conDataCreateProductException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to create new Product!" });
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
