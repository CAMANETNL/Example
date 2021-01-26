using AutoMapper;
using Example.API.Common;
using Example.Domain.Companies;
using Example.Domain.SharedKernel.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace Example.API.Companies
{
    [ApiController]
    [Route("[controller]")]
    public class CompaniesController : BaseApiController
    {
        private readonly IRepository<Company> _companiesRepo;
        private readonly IMapper _mapper;

        public CompaniesController(IRepository<Company> companiesRepo, IMapper mapper)
        {
            _companiesRepo = companiesRepo;
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

        [ProducesResponseType(typeof(/*TODO*/object), (int)HttpStatusCode.Created)]
        public async override Task<IActionResult> CreateAsync([FromBody] /*TODO*/object company)
        {
            /*TODO*/
            return await Task.FromResult(Created(string.Empty, company));
        }
    }
}
