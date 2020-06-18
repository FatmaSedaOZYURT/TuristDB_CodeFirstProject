using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristDB_App.Model
{
    public class Country
    {
        public Country()
        {
            Tourists = new HashSet<Tourist>();
        }
        public int CountryID { get; set; }
        public string CountryDescription { get; set; }


        public ICollection<Tourist> Tourists { get; set; }
    }
}
