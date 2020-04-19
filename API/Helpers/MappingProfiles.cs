using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
            .ForMember(s => s.ProductBrand, o => o.MapFrom(s => s.ProductBrand.Name))
            .ForMember(s => s.ProductType, o => o.MapFrom(s => s.ProductType.Name))
            .ForMember(s => s.PictureUrl, o => o.MapFrom<ProductUrlResolver>());
        }
    }
}