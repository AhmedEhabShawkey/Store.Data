using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Model
{
    public class Product:BaseEntity<int>
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public Decimal price { get; set; }
         public productType Type { get; set; }
        public int TypeId { get; set; }
        public BrandType Brand { get; set; }
        public int BrandId { get; set; }
    }
}
