using AutoMapper;
using Inquiry.API.Post.DTO.InternalAPI.Request;
using Inquiry.API.Post.DTO.InternalAPI.Response;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Inquiry.API.Post.Application
{
    public class InquiryPost : IInquiryPost
    {
        private readonly IMapper _mapper;
        public InquiryPost(IMapper mapper)
        {
            _mapper = mapper;
        }

        public AddressResponse GetAddressByPostalCode(PostalCodeRequest postalCode)
        {
            // Get Address By PostalCode Inquiry
            var response = "Tehran, Mirdamad";
            return Ok();
        }
        
    }
}
