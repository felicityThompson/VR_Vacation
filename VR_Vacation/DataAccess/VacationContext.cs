using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;

namespace VR_Vacation.DataAccess
{
    public class VacationContext : DbContext
    {
        public VacationContext(): base("name=VacationContext"){}

        public virtual DbSet<Destination> Destinations { get; set; }
        public virtual DbSet<Experience> Experiences { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Package> Packages { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}