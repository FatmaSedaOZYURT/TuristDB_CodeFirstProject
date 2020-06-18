using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristDB_App.Mapping;
using TuristDB_App.Model;

namespace TuristDB_App
{
    class TouristDbContext : DbContext
    {
        public TouristDbContext():base("Server = .; Database= TouristDB;Trusted_Connection =true")
        {

        }
        public DbSet<Plan> Plans{ get; set; }
        public DbSet<Tourist> Tourists { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add( new CountryMapping());
            modelBuilder.Configurations.Add(new GenderMapping());
            modelBuilder.Configurations.Add(new GuideMapping());
            modelBuilder.Configurations.Add(new LocationMapping());
            modelBuilder.Configurations.Add(new NationalityMapping());
            modelBuilder.Configurations.Add(new PlanMapping());
            modelBuilder.Configurations.Add(new TouristMapping());

        }
    }
}
