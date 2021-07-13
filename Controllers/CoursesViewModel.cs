using System;
using System.Linq;
using LAB4_5_6.Models;

namespace LAB4_5_6.Controllers
{
    internal class CoursesViewModel
    {
        public bool ShowAction { get; internal set; }
        public IQueryable<Course> UpcommingCourses { get; internal set; }

        internal DateTime GetDateTime()
        {
            throw new NotImplementedException();
        }
    }
}