using AutoMapper;
using Example.Domain.Contracts;

namespace Example.Application.Contracts
{
    public class MappingContractsProfile : Profile
    {
        public MappingContractsProfile()
        {
           
            CreateMap<ContractTemplate, AddContractDTO>()
                .ForMember(dto => dto.CompanyId, options => options.MapFrom(src => src.Id))
                .ReverseMap();

            CreateMap<AddContractDTO, Contract>()
                .ForCtorParam("price", s => s.MapFrom(dto => dto.Price))
                .ForCtorParam("companyId", s => s.MapFrom(dto => dto.CompanyId))
                .ForCtorParam("templateId", s => s.MapFrom(dto => dto.TemplateId));

            // GET
            CreateMap<Contract, GetContractDTO>()
               .ForMember(s => s.Name, options => options.MapFrom(d => d.Price))
               .ForMember(s => s.Signed, options => options.MapFrom(d => d.Signed))
               ;

            CreateMap<Contract, GetContractDTO>()
                .ForMember(d => d.Price, options => options.MapFrom(s => s.Price))
                .ForMember(d => d.Signed, options => options.MapFrom(s => s.Signed))
                .ForMember(d => d.Name, options => options.MapFrom(s => s.Company.Name))
                .ForMember(d => d.Text, options => options.MapFrom(s => s.Template.Text))
                ;
          
        }
    }
}