using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CityDropdownMvc.Models
{
    public partial class DateModel1 : DbContext
    {
        public DateModel1()
            : base("name=DateModel1")
        {
        }

        public virtual DbSet<tblState> tblStates { get; set; }
        public virtual DbSet<tblCity> tblCities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblState>()
                .HasMany(e => e.tblCities)
                .WithRequired(e => e.tblState)
                .WillCascadeOnDelete(false);
        }
    }
}
