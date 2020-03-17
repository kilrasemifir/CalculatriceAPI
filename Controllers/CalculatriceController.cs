using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatriceAPI.Controllers
{
    using DTO;

    [Route("api/[controller]")]
    [ApiController]
    public class CalculatriceController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Is Ok";
        }

        [HttpPost]
        public string Post([FromBody] Data content)
        {
            string res;
            switch (content.operation)
            {
                case "AND":
                    res = (content.a + content.b).ToString();
                    break;
                case "MUL":
                    res = (content.a * content.b).ToString();
                    break;
                case "DIV":
                    res = (content.a / content.b).ToString();
                    break;
                case "SUB":
                    res = (content.a - content.b).ToString();
                    break;
                default:
                    res = $"Operation {content.operation} n'est pas definie!";
                    break;
            }
            return res;
        }

        [HttpGet]
        [Route("add/{a}/{b}")]
        public string Addition(int a, int b)
        {
            return (a + b).ToString();
        }

        [HttpGet]
        [Route("params")]
        public string Params(int a, int b, string o)
        {
            string res;
            switch (o)
            {
                case "AND":
                    res = (a + b).ToString();
                    break;
                case "MUL":
                    res = (a * b).ToString();
                    break;
                case "DIV":
                    res = (a / b).ToString();
                    break;
                case "SUB":
                    res = (a - b).ToString();
                    break;
                default:
                    res = $"Operation {o} n'est pas definie!";
                    break;
            }
            return res;
        }
    }
}