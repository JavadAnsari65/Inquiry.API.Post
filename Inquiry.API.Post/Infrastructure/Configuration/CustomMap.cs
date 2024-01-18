using AutoMapper;
using Inquiry.API.Post.DTO.InternalAPI.Response;


namespace Inquiry.API.Post.Infrastructure.Configuration
{
    public class CustomMap:Profile
    {
        public CustomMap()
        {
            CreateMap<DTO.ExternalAPI.Response.AddressResponse, DTO.InternalAPI.Response.AddressResponse>().ReverseMap();
            CreateMap<DTO.ExternalAPI.Embeded.Street, DTO.InternalAPI.Embeded.Street>().ReverseMap();
        }
    }
}
