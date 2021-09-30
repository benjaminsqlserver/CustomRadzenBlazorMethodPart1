using Radzen;
using System;
using System.Web;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Data;
using System.Text.Encodings.Web;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;
using CustomMethodBenjamin.Data;


namespace CustomMethodBenjamin
{
    public partial class ConDataService
    {

        //custom method to search for product based on product name at Data Access Layer
        public async Task<IEnumerable<Models.ConData.Product>> SearchForProductDALAsync(string search)
        {
            var products = new List<Models.ConData.Product>();

            try
            {
                var products1 = context.Products.Where(p => p.ProductName == search).AsQueryable();
                products1 = products1.Include(p => p.ProductCategory);

                if(products1.Any())
                {
                    products = await products1.ToListAsync();
                }
            }
            catch
            {
                throw;
            }

            return await Task.FromResult(products);
        }
    }
}
