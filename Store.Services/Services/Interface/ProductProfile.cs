using AutoMapper;
using Store.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services.Services.Interface
{
    public class ProductProfile :Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDetails>().ForMember(dest => dest.BrandName, options => options.MapFrom(src => src.Brand)).
                ForMember(dest => dest.TypeName, options => options.MapFrom(src => src.Type.Name));
            CreateMap<BrandType, BrandTypeDetails>();
            CreateMap<productType, BrandTypeDetails>();



        }
    }
}
