using AutoMapper;
using Example.API.Common;
using Example.Domain.Deals.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace Example.API.Deals
{
    [ApiController]
    [Route("[controller]")]
    public class DealsController : BaseApiController
    {
        private readonly IDealsService _service;
        private readonly IMapper _mapper;

        public DealsController(IDealsService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
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
