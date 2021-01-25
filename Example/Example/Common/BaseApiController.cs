using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace Example.API.Common
{
    public class BaseApiController : Controller
    {
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public virtual async Task<IActionResult> GetAsync()
        {
            return Ok();
        }

        [ProducesResponseType((int)HttpStatusCode.OK)] 
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public virtual async Task<IActionResult> GetAsync(int id)
        {
            return Ok();
        }
    }
}
