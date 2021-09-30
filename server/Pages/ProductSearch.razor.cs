using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Radzen;
using Radzen.Blazor;

namespace CustomMethodBenjamin.Pages
{
    public partial class ProductSearchComponent
    {
        //custom method to search datastore for products based on product name
        private async Task SearchForProductAsync()
        {
            try
            {
                searchResultList = await ConData.SearchForProductDALAsync(search);//method now exists in ConDataService.cs file
            }
            catch
            {
                NotificationService.Notify(NotificationSeverity.Error, "App Error!", "An Error Has Occurred!", 7000);
            }
        }


        //method to reset form

        private async Task ResetFormAsync()
        {
            search = String.Empty;
            searchResultList = new List<Models.ConData.Product>();
        }
    }
}
