using AutoMapper;
using Store.Data.Model;
using Store.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services.Services.Interface
{
    public class ProductService : IProductService
    {
        private readonly IUnitWork _unitWork;
        private readonly IMapper _mapper;

       public ProductService(IUnitWork unitWork,IMapper mapper)
        {
            _unitWork = unitWork;
            _mapper=mapper;
        }
        public async Task<IReadOnlyList<BrandTypeDetails>> GetAllBrandAsync()
        {
   var brands=await _unitWork.Repositroy<BrandTypeDetails,int>().GetALLAsNoTrackingAsync();
            var MappedBrands=_mapper.Map<IReadOnlyList<BrandTypeDetails>>(brands);
            IReadOnlyList<BrandTypeDetails> mappedBrands = _mapper.Map<IReadOnlyList<ProductDetails>>(brands);

            return mappedBrands;
        }

        public async Task<IReadOnlyList<ProductDetails>> GetAllProductByIdAsync()
        {
          var products= await _unitWork.Repositroy<Store.Data.Model.Product,int>().GetALLAsNoTrackingAsync();
            var mappedproducts=_mapper .Map<IReadOnlyList<ProductDetails>>(products);
         
            return mappedproducts;
        }

        public async Task<IReadOnlyList<BrandTypeDetails>> GetAllTypesAsync()
        {
            var Types = await _unitWork.Repositroy<BrandTypeDetails, int>().GetALLAsNoTrackingAsync();
            IReadOnlyList<BrandTypeDetails> mappedTypes =_mapper.Map<IReadOnlyList<ProductDetails>>(Types);

            return mappedTypes;
        }

        public async Task<ProductDetails> GetProductDetailsByIdAsync(int? productid)
        {
            if (productid is null)
                throw new Exception("Id is Null");
            var product = await _unitWork.Repositroy<Store.Data.Model.Product, int>().GetByIdAsync(productid.Value);
            if(product is null)
                throw new Exception("Product Not Found");

            var mappedProduct = _mapper.Map<IReadOnlyList<ProductDetails>>(product);


            return mappedProduct;

        }
    }

      
    }
