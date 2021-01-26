using Example.API.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Example.API.Companies
{
    [ApiController]
    [Route("[controller]")]
    public class CompaniesController : BaseApiController
    {
        public CompaniesController(/*TODO*/)
        {
        }

        public async override Task<IActionResult> GetAsync()
        {
            /*TODO*/
            return await Task.FromResult(Ok());
        }

        public async override Task<IActionResult> GetAsync(int id)
        {
            /*TODO*/
            return await Task.FromResult(Ok());
        }

        [ProducesResponseType(typeof(/*TODO*/object), (int)HttpStatusCode.Created)]
        public async override Task<IActionResult> CreateAsync([FromBody] /*TODO*/object company)
        {
            /*TODO*/
            return await Task.FromResult(Created(string.Empty, company));
        }
    }
}
