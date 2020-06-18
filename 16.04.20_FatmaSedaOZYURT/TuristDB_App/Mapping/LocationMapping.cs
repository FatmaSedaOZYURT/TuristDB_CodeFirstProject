using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristDB_App.Model;

namespace TuristDB_App.Mapping
{
    public class LocationMapping : EntityTypeConfiguration<Location>
    {
        public LocationMapping()
        {
            HasKey(a => a.LocationID);

            Property(a => a.LocationDescription)
                .HasMaxLength(100)
                .IsRequired();

            HasMany(a => a.Plans)
                .WithRequired(a => a.Location)
                .HasForeignKey(a=>a.LocationID);
        }
    }
}
