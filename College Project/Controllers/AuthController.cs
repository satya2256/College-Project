using College_Project.BusinessObjects.Providers.Authentication;
using College_Project.Entities;
using College_Project.Infra.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace College_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost("RegisterStudent")]
        public ClientResponse<UserStudent> RegisterStudent([FromBody] UserStudent userStudent)
        {
            AuthProvider authProvider = new AuthProvider();
            Serilog.Log.Information("Get '" + this.GetType() + "' Input Params -> Event:{Event}, EventStatus:{EventStatus}", "RegisterStudent", "ControllerStarted");
            var reg = authProvider.RegisterStudent(userStudent);
            return reg;

        }
        [HttpGet("GetStudentDetails")]
        public ClientResponse<UserStudent> GetStudentDetails(string rollNumber)
        {
            AuthProvider authProvider = new AuthProvider();
            var student = authProvider.GetStudentDetails(rollNumber);
            return student;

        }
        [HttpGet("StudentLogin")]
        public ClientResponse<UserStudent> StudentLogin(string rollNumber, string password)
        {
            AuthProvider authProvider = new AuthProvider();
            var loggedinStudent = authProvider.GetStudentDetails(rollNumber,password);
            return loggedinStudent;

        }
    }
        
}
