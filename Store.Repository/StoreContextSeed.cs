using Microsoft.Extensions.Logging;
using Store.Data.Contexts;
using Store.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Store.Repository
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync (StoreDbContexts contexts , ILoggerFactory loggerFactory)
        {
            try
            {
                if (contexts.BrandTypes != null && !contexts.BrandTypes.Any())
                {
                    var brandsData = File.ReadAllText("../Store .Repository/SeedData/brands.json");
                    var brands = JsonSerializer.Deserialize<List<BrandType>>(brandsData);
                    if(brandsData != null )
                        await contexts.BrandTypes.AddRangeAsync(brands);
                }
                if (contexts.productTypes != null && !contexts.productTypes.Any())
                {
                    var typesData = File.ReadAllText("../Store .Repository/SeedData/brands.json");
                    var types = JsonSerializer.Deserialize<List<productType>>(typesData);
                    if (typesData != null)
                        await contexts.productTypes.AddRangeAsync(types);
                }
                if (contexts.Products != null && !contexts.Products.Any())
                {
                    var productData = File.ReadAllText("../Store .Repository/SeedData/brands.json");
                    var products = JsonSerializer.Deserialize<List<productType>>(productData);
                    if (productData != null)
                        await contexts.productTypes.AddRangeAsync(products);
                }

                }

            catch (Exception ex)
            {

                var logger = loggerFactory.CreateLogger<StoreContextSeed>();
                logger.LogError(ex.Message);

            }



        }
         
        
        
        
       
    }
}
