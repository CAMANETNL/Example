using AutoMapper;
using Example.Domain.Companies;
using Example.Domain.Contracts;

namespace Example.Application.Companies
{
    public class MappingCompaniesProfile : Profile
    {
        public MappingCompaniesProfile()
        {
            // ADD
            CreateMap<AddCompanyDTO, Company>()
               .ForMember(s => s.Name, options => options.MapFrom(d => d.Name));

            // GET
            CreateMap<Company, GetCompanyDTO>()
               .ForMember(s => s.Name, options => options.MapFrom(d => d.Name))
                .ForMember(s => s.Id, options => options.MapFrom(d => d.Id))
               ;
            
        }
    }
}