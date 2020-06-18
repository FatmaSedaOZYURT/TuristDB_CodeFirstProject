using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristDB_App.Model
{
    public class Location
    {
        public Location()
        {
            Plans = new HashSet<Plan>();
        }
        public int LocationID { get; set; }
        public string LocationDescription { get; set; }

        public ICollection<Plan> Plans { get; set; }
    }
}
