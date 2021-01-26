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
            // TODO: ExceptionHandling NotFound
            contract.MarkAsSigned();
            return Ok(_mapper.Map<GetContractDTO>(await _contractsRepo.UpdateAsync(contract)));
        }

        /// <summary>
        /// When the company (buy or sell) signes the contract, the status is updated
        /// Once signed it can't be undone
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async override Task<IActionResult> UpdateAsync(int id)
        {
            var contract = await _contractsRepo.GetByIdAsync(id);
            // TODO: ExceptionHandling: Not Found
            contract.MarkAsSigned();
            // TODO: When requesting to sign when already signed throw Exception
            return Ok(_mapper.Map<GetContractDTO>(await _contractsRepo.UpdateAsync(contract)));
        }
        
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public async Task<IActionResult> CreateAsync()
        {
            return await Task.FromResult(StatusCode(501, "Not Implemented"));
        }
         
    }
}
