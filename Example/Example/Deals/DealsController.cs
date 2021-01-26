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
       
        public DealsController(/*TODO*/)
        {
        }

        public override async Task<IActionResult> GetAsync()
        {
            /*TODO*/
            return await Task.FromResult(Ok());
        }

        public override async Task<IActionResult> GetAsync(int id)
        {
            /*TODO*/
            return await Task.FromResult(Ok());
        }

        public override async Task<IActionResult> CreateAsync([FromBody] /*TODO*/ object deal)
        {
            /*TODO*/
            return await Task.FromResult(Created(string.Empty, deal));
        }


    }
}
