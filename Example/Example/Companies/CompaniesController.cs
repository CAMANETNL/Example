using AutoMapper;
using Example.API.Common;
using Example.Application.Companies;
using Example.Domain.Companies;
using Example.Domain.Companies.Specifications;
using Example.Domain.SharedKernel.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
            var companies = await _companiesRepo.ListAsync(new GetCompaniesSpecification());
            return Ok(_mapper.Map<IEnumerable<GetCompanyDTO>>(companies));
        }

        public async override Task<IActionResult> GetAsync(int id)
        {
            var company = await _companiesRepo.GetByIdAsync(id);
            return Ok(_mapper.Map<GetCompanyDTO>(company));
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType(typeof(GetCompanyDTO), (int)HttpStatusCode.Created)]
        public async Task<IActionResult> CreateAsync([FromBody] AddCompanyDTO company)
        {
            var companyCreated = await _companiesRepo.AddAsync(_mapper.Map<Company>(company));
            return Created(string.Empty, _mapper.Map<GetCompanyDTO>(companyCreated));
        }
    }
}
