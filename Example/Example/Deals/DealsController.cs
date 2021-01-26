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

        public override async Task<IActionResult> GetAsync()
        {
            return await Task.FromResult(Ok());

        }

        public override async Task<IActionResult> GetAsync(int id)
        {
            return await Task.FromResult(Ok());
        }

    }
}
