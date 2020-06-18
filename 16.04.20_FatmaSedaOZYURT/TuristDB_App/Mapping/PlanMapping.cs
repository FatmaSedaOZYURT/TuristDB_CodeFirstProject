using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristDB_App.Model;

namespace TuristDB_App.Mapping
{
    public class PlanMapping : EntityTypeConfiguration<Plan>
    {
        public PlanMapping()
        {
            HasKey(a => new { a.TouristID, a.LocationID, a.GuideID });

            Property(a => a.ArrivalDateInTurkey)
                .IsRequired();

            
        }
    }
}
