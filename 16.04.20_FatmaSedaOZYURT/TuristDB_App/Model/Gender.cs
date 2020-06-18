using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristDB_App.Model
{
    public class Gender
    {
        public Gender()
        {
            Tourist = new HashSet<Tourist>();
        }
        public int GenderID { get; set; }
        public string GenderDescription { get; set; }
        public ICollection<Tourist> Tourist { get; set; }
    }
}
