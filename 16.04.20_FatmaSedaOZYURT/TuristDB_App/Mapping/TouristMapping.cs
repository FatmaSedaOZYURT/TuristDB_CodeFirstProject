using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristDB_App.Model;

namespace TuristDB_App.Mapping
{
    public class TouristMapping : EntityTypeConfiguration<Tourist>
    {
        public TouristMapping()
        {
            HasKey(a => a.TouristID);

            Property(a => a.Name)
                .HasMaxLength(30);
            
            Property(a=>a.Name)
                .IsRequired();

            Property(a => a.Surname)
                .HasMaxLength(40)
                .IsRequired();

            Property(a => a.BirthDate)
                .IsRequired();

            HasMany(a => a.Plans)
                .WithRequired(a => a.Tourist)
                .HasForeignKey(a => a.TouristID);

            
                
        }
    }
}
