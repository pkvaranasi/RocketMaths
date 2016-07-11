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
        public double Add(int a, int b)
        {
            return (a + b).ToString();
            return (a + b);
        }

        [Route("api/Maths/Subtract/{a}/{b}")]
        [HttpGet]
        public double Subtract(int a, int b)
        {
            return (a - b);
        }

        [Route("api/Maths/Multiply/{a}/{b}")]
        [HttpGet]
        public double Multiply(int a, int b)
        {
            return (a * b);
        }

        [Route("api/Maths/Divide/{a}/{b}")]
        [HttpGet]
        public double Divide(int a, int b)
        {
            return (a / b);
        }

        [Route("api/Maths/GetName")]
        [HttpGet]
        public string GetName()
        {
            return "Hello User.";
        }
    }
}