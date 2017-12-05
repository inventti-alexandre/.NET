using FinanciasWeb.Domain.Entitys;
using FinanciasWeb.Infra.Persistence.Map;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanciasWeb.Infra.Persistence.DataContexts
{
    public class StoreDataContext : DbContext
    {
        public StoreDataContext(): base("ConnectionString")
        {
            //Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<User> User { get; set; }
        public DbSet<Category> Category {get; set;}
        public DbSet<Product> Product {get; set;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new ProductMap());           
        }
    }
}
