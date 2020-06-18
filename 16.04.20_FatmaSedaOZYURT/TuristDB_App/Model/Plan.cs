using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristDB_App.Model
{
    public class Plan
    {
        public int TouristID { get; set; }
        public int GuideID { get; set; }
        public int LocationID { get; set; }
        public Tourist Tourist { get; set; }
        public Guide Guide { get; set; }
        public Location Location { get; set; }
        public DateTime ArrivalDateInTurkey { get; set; }
    }
}
