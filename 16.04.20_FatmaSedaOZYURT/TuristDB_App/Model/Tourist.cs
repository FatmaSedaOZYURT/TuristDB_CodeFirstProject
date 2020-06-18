using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristDB_App.Model
{
    public class Tourist
    {
        public Tourist()
        {
            Plans = new HashSet<Plan>();
            Countries = new HashSet<Country>();
        }
        public int TouristID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }

        public Gender Gender { get; set; }
        public Nationality Nationality { get; set; }

        public int NationalityID { get; set; }
        public int GenderID { get; set; }

        public ICollection<Plan> Plans { get; set; }
        public ICollection<Country> Countries { get; set; }
    }
}
