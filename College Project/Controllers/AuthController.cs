using College_Project.BusinessObjects.Providers.Authentication;
using College_Project.Entities;
using College_Project.Infra.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace College_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        readonly IAuthprovider _authProvider;
        public AuthController(IAuthprovider authprovider)
        {
            _authProvider = authprovider;
        }
        [HttpPost("RegisterStudent")]
        public ClientResponse<UserStudent> RegisterStudent([FromBody] UserStudent userStudent)
        {
            //AuthProvider authProvider = new AuthProvider();
            Serilog.Log.Information("Get '" + this.GetType() + "' Input Params -> Event:{Event}, EventStatus:{EventStatus}", "RegisterStudent", "ControllerStarted");
            var reg = _authProvider.RegisterStudent(userStudent);
            return reg;

        }
        [HttpGet("GetStudentDetails")]
        public ClientResponse<UserStudent> GetStudentDetails(string rollNumber)
        {
            //AuthProvider authProvider = new AuthProvider();
            var student = _authProvider.GetStudentDetails(rollNumber);
            return student;

        }
        [HttpGet("GetStudentsDetailsByBranchName")]
        public ClientResponse<List<UserStudent>> GetStudentsDetailsByBranchName(string branchName)
        {
            //AuthProvider authProvider = new AuthProvider();
            return _authProvider.GetStudentsDetailsByBranchName(branchName);
        }
        [HttpGet("StudentLogin")]
        public ClientResponse<UserStudent> StudentLogin(string rollNumber, string password)
        {
           //AuthProvider authProvider = new AuthProvider();
            var loggedinStudent = _authProvider.GetStudentDetails(rollNumber,password);
            return loggedinStudent;

        }
        [HttpPost("UpdateStudent")]
        public ClientResponse<UserStudent> UpdateStudent([FromBody]UserStudent userStudent )
        {
           // AuthProvider authProvider = new AuthProvider();
            return _authProvider.UpdateStudent(userStudent);
        }
        
        [HttpDelete("DeleteStudent")]
        public ClientResponse<bool> DeleteStudent(string rollNumber,string password)
        {
           // AuthProvider authProvider = new AuthProvider();
            var deletedStudent = _authProvider.DeleteStudent(rollNumber, password);
            return deletedStudent;

        }
        [HttpPost("RegisterProfessor")]
        public ClientResponse<UserProfessor> RegisterProfessor([FromBody]UserProfessor userProfessor)
        {
          //  AuthProvider authProvider = new AuthProvider();
            var register = _authProvider.RegisterProfessor(userProfessor);
            return register;
        }
        [HttpGet("GetProfessorDetails")]
        public ClientResponse<UserProfessor> GetProfessorDetails(string email)
        {
           // AuthProvider authProvider = new AuthProvider();
            var professorDetails = _authProvider.GetProfessorDetails(email);
            return professorDetails;
        }
        [HttpPost("ConvertCSVtoDataTable")]
        public DataTable ConvertCSVtoDataTable(string strFilePath)
        {
            var data = _authProvider.ConvertCSVtoDataTable(strFilePath);
            return data;
        }
    }

}
