using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabSupportWebApp.Models
{
    public class StudentUser
    {
        public int Qcode { get; set; }
        public int Qnum { get; set; }
        public string Name { get; set; }
        public float ElapsedTime { get; set; }
    }
}