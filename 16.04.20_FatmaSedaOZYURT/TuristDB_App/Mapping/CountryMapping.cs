using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristDB_App.Model;

namespace TuristDB_App.Mapping
{
    public class CountryMapping : EntityTypeConfiguration<Country>
    {
        public CountryMapping()
        {
            HasKey(a => a.CountryID);

            Property(a => a.CountryDescription)
                .HasMaxLength(50)
                .IsRequired();


            HasMany(a => a.Tourists)
                .WithMany(a => a.Countries)
                .Map(a => 
                {
                    a.ToTable("TouristCountryDetail");
                    a.MapLeftKey("CountryID");
                    a.MapRightKey("TouristID");
                });


        }
    }
}
