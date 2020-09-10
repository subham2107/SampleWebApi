using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SampleWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Route("GetNames")]
        public List<string> GetNames()
        {
            List<string> l = new List<string>();
            l.Add("Sheldon Cooper");
            l.Add("Rachel Green");
            return l;
        }
    }
}
