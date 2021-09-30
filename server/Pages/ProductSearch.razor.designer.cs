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
    public partial class ProductSearchComponent : ComponentBase
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
        protected RadzenDataGrid<CustomMethodBenjamin.Models.ConData.Product> grid0;

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

        IEnumerable<CustomMethodBenjamin.Models.ConData.Product> _searchResultList;
        protected IEnumerable<CustomMethodBenjamin.Models.ConData.Product> searchResultList
        {
            get
            {
                return _searchResultList;
            }
            set
            {
                if (!object.Equals(_searchResultList, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "searchResultList", NewValue = value, OldValue = _searchResultList };
                    _searchResultList = value;
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
            search = "";

            searchResultList = new List<CustomMethodBenjamin.Models.ConData.Product>(){};
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            await SearchForProductAsync();
        }

        protected async System.Threading.Tasks.Task Button1Click(MouseEventArgs args)
        {
            await ResetFormAsync();
        }
    }
}
