using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AspNetMvcECommerce.Models
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext() : base ("DefaultConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) { modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>(); }

        public System.Data.Entity.DbSet<AspNetMvcECommerce.Models.Departaments> Departaments { get; set; }

        public System.Data.Entity.DbSet<AspNetMvcECommerce.Models.City> Cities { get; set; }

        public System.Data.Entity.DbSet<AspNetMvcECommerce.Models.Company> Companies { get; set; }

        public System.Data.Entity.DbSet<AspNetMvcECommerce.Models.User> Users { get; set; }
    }
}