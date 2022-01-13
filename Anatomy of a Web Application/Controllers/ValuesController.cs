using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Anatomy_of_a_Web_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            Thread.Sleep(5000);
            return new string[] { "value1", "value2" };
        }

        //api/values/4
        [HttpGet("{id}")]
        public async Task<IEnumerable<string>> Get(int id)
        {
            await Task.Delay(5000);
            return new string[] { "value1", "value2" };
        }

    }
}
