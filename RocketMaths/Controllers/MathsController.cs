using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RocketMaths.Controllers
{
    public class MathsController : ApiController
    {
        [Route("api/Maths/Add/{a}/{b}")]
        [HttpGet]
        public string Add(int a, int b)
        {
            return (a + b).ToString();
        }

        [Route("api/Maths/Subtract/{a}/{b}")]
        [HttpGet]
        public string Subtract(int a, int b)
        {
            return (a - b).ToString();
        }

        [Route("api/Maths/Multiply/{a}/{b}")]
        [HttpGet]
        public string Multiply(int a, int b)
        {
            return (a * b).ToString();
        }

        [Route("api/Maths/Divide/{a}/{b}")]
        [HttpGet]
        public string Divide(int a, int b)
        {
            return (a / b).ToString();
        }
    }
}