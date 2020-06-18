using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristDB_App.Model;

namespace TuristDB_App.Mapping
{
    public class GenderMapping : EntityTypeConfiguration<Gender>
    {
        public GenderMapping()
        {
            HasKey(a => a.GenderID);

            Property(a => a.GenderDescription)
                .HasMaxLength(15)
                .IsRequired();


            HasMany(a => a.Tourist)
                .WithRequired(a => a.Gender)
                .HasForeignKey(a=>a.GenderID);

        }
    }
}
