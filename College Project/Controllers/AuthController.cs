using College_Project.BusinessObjects.Providers.Authentication;
using College_Project.Entities;
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
        public UserStudent RegisterStudent([FromBody]UserStudent userStudent)
        {
            AuthProvider authProvider = new AuthProvider();
            return authProvider.RegisterStudent(userStudent);
        }
    }
}
