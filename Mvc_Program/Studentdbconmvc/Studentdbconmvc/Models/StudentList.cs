using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Studentdbconmvc.Models
{
    public class StudentList
    {
        public int StdId { get; set; } 
        public string Name { get; set; }
        public int Rollno { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
    }
}