using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristDB_App.Model;

namespace TuristDB_App.Mapping
{
    public class GuideMapping : EntityTypeConfiguration<Guide>
    {
        public GuideMapping()
        {
            HasKey(a => a.GuideID);

            Property(a => a.Name)
                .HasMaxLength(30)
                .IsRequired();
            Property(a => a.Surname)
                .HasMaxLength(45)
                .IsRequired();
            Property(a => a.PhoneNumber)
                .HasMaxLength(11)
                .IsRequired();

            HasMany(a => a.Plans)
                .WithRequired(a => a.Guide)
                .HasForeignKey(a=>a.GuideID);
    }
    }
}
