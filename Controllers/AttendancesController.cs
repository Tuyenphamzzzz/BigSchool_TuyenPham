using LAB4_5_6.DTOs;
using LAB4_5_6.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LAB4_5_6.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbContext;
        public AttendancesController()
        {
            _dbContext = new ApplicationDbContext();

        }


        [HttpPost]
        public IHttpActionResult Attend(AttendanceDto attendanceDto)
        {
            var UserId = User.Identity.GetUserId();
            if (_dbContext.Attendances.Any(a => a.AttendeeId == UserId && a.CourseId == attendanceDto.CourseId))
                return BadRequest("The Attendance already exists!");

            {
                var attendance = new Attendance
                {
                    CourseId = attendanceDto.CourseId,
                    AttendeeId = UserId
                };
                _dbContext.Attendances.Add(attendance);
                _dbContext.SaveChanges();
                return Ok();
            }
        }

    }
}
