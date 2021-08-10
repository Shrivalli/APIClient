using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIClient.Models
{
    public class Emp
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public double? sal { get; set; }
        public DateTime? doj { get; set; }
        public string city { get; set; }
        public string branch { get; set; }

        
    }
}


