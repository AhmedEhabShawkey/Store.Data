using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services.Services.Interface
{
    public class ProductDetails
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public DateTime Created { get; set; }
        public string? Description { get; set; }
        public Decimal Price { get; set; }
        public string  BrandName { get; set; }
        public String TypeName  { get; set; }



    }
}
