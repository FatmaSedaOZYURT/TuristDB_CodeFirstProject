﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristDB_App.Model
{
    public class Guide
    {
        public Guide()
        {
            Plans = new HashSet<Plan>();
        }
        public int GuideID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<Plan> Plans { get; set; }
    }
}
