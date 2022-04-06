using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_15.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        private readonly ILogger<HelloController> logger;

        public HelloController(ILogger<HelloController> logger)
        {
            this.logger = logger;
        }
        [HttpGet]
        public IEnumerable<string> Get()
        {
            logger.LogInformation("Index method Called");
            logger.LogWarning("Index method Called Warning");
            return new string[] { "Hello", "World" };
        }
    }
}
