using AutoMapper;
using Example.Domain.Deals;

namespace Example.Application.Deals
{
    public class MappingDealsProfile : Profile
    {
        public MappingDealsProfile()
        {
            CreateMap<AddDealDTO, Deal>()
                .ForCtorParam("buy", s => s.MapFrom(dto => dto.Buy))
                .ForCtorParam("sell", s => s.MapFrom(dto => dto.Sell));

            CreateMap<Deal, GetDealDTO>()
                .ForMember(d => d.Status, options => options.MapFrom(s => s.Status))
                .ForMember(d => d.Buy, options => options.MapFrom(s => s.Buy))
                .ForMember(d => d.Sell, options => options.MapFrom(s => s.Sell))
                ;
        }
    }
}