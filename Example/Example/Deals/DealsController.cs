using AutoMapper;
using Example.API.Common;
using Example.Application.Deals;
using Example.Domain.Deals.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
            var deals = await _service.GetDealsAsync();
            return Ok(_mapper.Map<IEnumerable<GetDealDTO>>(deals));
        }

        public override async Task<IActionResult> GetAsync(int id)
        {
            var deal = await _service.GetDealAsync(id);
            return Ok(_mapper.Map<GetDealDTO>(deal));
        }


        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public async Task<IActionResult> CreateAsync([FromBody] AddDealDTO deal)
        {
            var dealCreated = await _service.AddDealAsync(
                  deal.Buy.Price,
                  deal.Buy.CompanyId,
                  deal.Buy.TemplateId,
                  deal.Sell.Price,
                  deal.Sell.CompanyId,
                  deal.Sell.TemplateId);

            return Ok(_mapper.Map<GetDealDTO>(dealCreated));
        }

    }
}
