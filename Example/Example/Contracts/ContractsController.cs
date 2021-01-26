using AutoMapper;
using Example.API.Common;
using Example.Domain.Contracts;
using Example.Domain.SharedKernel.Interfaces;
using Microsoft.AspNetCore.Mvc;
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
            /*TODO*/
            return await Task.FromResult(Ok());
        }

        public async override Task<IActionResult> GetAsync(int id)
        {
            /*TODO*/
            return await Task.FromResult(Ok());
        }

        public async override Task<IActionResult> UpdateAsync(int id)
        {
            /*TODO*/
            return await Task.FromResult(Ok());
        }
    }
}
