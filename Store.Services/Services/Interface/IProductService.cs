using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services.Services.Interface
{
    public interface IProductService
    {
        Task<ProductDetails> GetProductDetailsByIdAsync();
        Task<IReadOnlyList<ProductDetails>> GetAllProductByIdAsync(int? id);
        Task<IReadOnlyList<BrandTypeDetails>> GetAllBrandAsync();
        Task<IReadOnlyList<BrandTypeDetails>> GetAllTypesAsync();




    }
}
