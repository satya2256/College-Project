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
        public async Task<ClientResponse<UserStudent>> RegisterStudent([FromBody]UserStudent userStudent)
        {
            AuthProvider authProvider = new AuthProvider();
            Serilog.Log.Information("Get '" + this.GetType() + "' Input Params -> Event:{Event}, EventStatus:{EventStatus}", "RegisterStudent", "ControllerStarted");
            var reg = await authProvider.RegisterStudent(userStudent);
            return reg;
            
        }
    }
}
