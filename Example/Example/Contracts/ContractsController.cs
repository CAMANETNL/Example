using AutoMapper;
using Example.API.Common;
using Example.Application.Contracts;
using Example.Domain.Contracts;
using Example.Domain.SharedKernel.Interfaces;
using Microsoft.AspNetCore.Mvc;
using POCApi.Core.Specifications;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Example.API.Contracts
{
    [ApiController]
    [Route("[controller]")]
    public class ContractsController : BaseApiController
    {
        private readonly IRepository<Contract> _contractsRepo;
        private readonly IMapper _mapper;

        public ContractsController(IRepository<Contract> contractsRepo, IMapper mapper)
        {
            _contractsRepo = contractsRepo;
            _mapper = mapper;
        }

        public async override Task<IActionResult> GetAsync()
        {
            var contracts = await _contractsRepo.ListAsync(new GetContractsSpecification());
            return Ok(_mapper.Map<IEnumerable<GetContractDTO>>(contracts));
        }

        public async override Task<IActionResult> GetAsync(int id)
        {
            var contract = await _contractsRepo.GetByIdAsync(id);
            contract.MarkAsSigned();
            return Ok(_mapper.Map<GetContractDTO>(await _contractsRepo.UpdateAsync(contract)));
        }

        public async override Task<IActionResult> UpdateAsync(int id)
        {
            var contract = await _contractsRepo.GetByIdAsync(id);
            contract.MarkAsSigned();
            return Ok(_mapper.Map<GetContractDTO>(await _contractsRepo.UpdateAsync(contract)));
        }
        
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public async Task<IActionResult> CreateAsync([FromBody] object newObject)
        {
            return await Task.FromResult(StatusCode(501, "Not Implemented"));
        }
         
    }
}
