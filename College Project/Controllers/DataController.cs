using College_Project.BusinessObjects.Providers.Data;
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
    public class DataController : ControllerBase
    {
        [HttpGet("GetUserTypes")]
        public IEnumerable<UserType> GetUserTypes()
        {
            DataProvider dataProvider = new DataProvider();

            return dataProvider.GetUserTypes();
        }
    }
}
