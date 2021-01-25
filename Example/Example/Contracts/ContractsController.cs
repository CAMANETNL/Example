using Example.API.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Example.API.Contracts
{
    [ApiController]
    [Route("[controller]")]
    public class ContractsController : BaseApiController
    {
        public ContractsController()
        {
        }

        [HttpGet]
        public async override Task<IActionResult> GetAsync()
        {
            return Ok();
        }

        [HttpGet("{id:int}")]
        public async override Task<IActionResult> GetAsync(int id)
        {
            return Ok();
        }
    }
}
