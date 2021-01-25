using Example.API.Common;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace Example.API.Deals
{
    [ApiController]
    [Route("[controller]")]
    public class DealsController : BaseApiController
    {
       
        public DealsController()
        {
        }

        [HttpGet]
        public override async Task<IActionResult> GetAsync()
        {
            return Ok();
        }


        [HttpGet("{id:int}")]
        public override async Task<IActionResult> GetAsync(int id)
        {
            return Ok();
        }

    }
}
