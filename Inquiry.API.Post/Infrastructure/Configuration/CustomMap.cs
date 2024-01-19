using AutoMapper;
using Inquiry.API.Post.DTO.InternalAPI.Response;


namespace Inquiry.API.Post.Infrastructure.Configuration
{
    public class CustomMap:Profile
    {
        public CustomMap()
        {
            CreateMap<DTO.ExternalAPI.Response.AddressResponse, DTO.InternalAPI.Response.AddressResponse>()
                .ForMember(dest => dest.StreetDetail, opt => opt.MapFrom(src => src.StreetDetail))
                .ReverseMap();
            CreateMap<DTO.ExternalAPI.Embeded.StreetEmbeded, DTO.InternalAPI.Embeded.StreetEmbeded>().ReverseMap();
        }
    }
}
