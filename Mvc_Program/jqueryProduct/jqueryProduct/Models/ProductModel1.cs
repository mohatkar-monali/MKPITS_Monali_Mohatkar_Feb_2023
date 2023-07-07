using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace jqueryProduct.Models
{
    public partial class ProductModel1 : DbContext
    {
        public ProductModel1()
            : base("name=ProductModel1")
        {
        }

        public virtual DbSet<tblCategory> tblCategories { get; set; }
        public virtual DbSet<tblProduct> tblProducts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblCategory>()
                .HasMany(e => e.tblProducts)
                .WithRequired(e => e.tblCategory)
                .WillCascadeOnDelete(false);
        }
    }
}
