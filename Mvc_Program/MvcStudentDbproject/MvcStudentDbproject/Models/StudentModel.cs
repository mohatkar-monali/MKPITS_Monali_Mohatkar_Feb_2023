using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcStudentDbproject.Models
{
    public class StudentModel
    {
        public int StdId { get; set; }
        public string Name { get; set; }
        public int Rollno { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
    }
}