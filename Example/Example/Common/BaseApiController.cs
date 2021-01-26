using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

/// <summary>
/// Responsecodes: https://restfulapi.net/
/// </summary>
namespace Example.API.Common
{
    
    public abstract class BaseApiController : Controller
    {

        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public virtual async Task<IActionResult> GetAsync()
        {
            return  await Task.FromResult(StatusCode(501, "Not Implemented"));
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType((int)HttpStatusCode.OK)] 
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public virtual async Task<IActionResult> GetAsync(int id)
        {
            return await Task.FromResult(StatusCode(501, "Not Implemented"));
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public virtual async Task<IActionResult> CreateAsync([FromBody] object newObject)
        {
            return await Task.FromResult(StatusCode(501, "Not Implemented"));
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public virtual async Task<IActionResult> UpdateAsync(int id)
        {
            return await Task.FromResult(StatusCode(501, "Not Implemented"));
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public virtual async Task<IActionResult> DeleteAsync(int id)
        {
            return await Task.FromResult(StatusCode(501, "Not Implemented"));
        }

    }
}
