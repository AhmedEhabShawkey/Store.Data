using Microsoft.EntityFrameworkCore;
using Store.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Contexts
{
    public class StoreDbContexts:DbContext
    {

        public StoreDbContexts(DbContextOptions<StoreDbContexts>options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<BrandType> BrandTypes { get; set; }
        public DbSet<productType> productTypes { get; set; }

    }
}
