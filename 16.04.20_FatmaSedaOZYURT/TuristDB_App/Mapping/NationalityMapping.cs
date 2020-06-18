using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristDB_App.Model;

namespace TuristDB_App.Mapping
{
    public class NationalityMapping : EntityTypeConfiguration<Nationality>
    {
        public NationalityMapping()
        {
            HasKey(a => a.NationalityID);

            Property(a => a.NationalityDescription)
                .HasMaxLength(30);

            HasMany(a => a.Tourists)
                .WithRequired(a => a.Nationality)
                .HasForeignKey(a=>a.NationalityID);
        }
    }
}
