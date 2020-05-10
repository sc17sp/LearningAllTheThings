using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webApp.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        [Display( Name ="Name")]
        public string StudentName { get; set; }
        public int Age { get; set; }
        public bool isNewlyEnrolled { get; set; }
        public string password { get; set; }


    }
}