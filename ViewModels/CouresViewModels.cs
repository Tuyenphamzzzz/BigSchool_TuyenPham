using LAB4_5_6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LAB4_5_6.ViewModels
{
    public class CouresViewModels
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}