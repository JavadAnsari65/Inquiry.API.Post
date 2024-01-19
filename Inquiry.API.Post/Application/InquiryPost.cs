using AutoMapper;
using Inquiry.API.Post.DTO.InternalAPI.Request;
using Inquiry.API.Post.DTO.InternalAPI.Response;
using Inquiry.API.Post.Infrastructure.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Inquiry.API.Post.Application
{
    public class InquiryPost : IInquiryPost
    {
        private readonly IMapper _mapper;
        private readonly LogService _logService;
        public InquiryPost(IMapper mapper, LogService logService)
        {
            _mapper = mapper;
            _logService = logService;
        }

        public AddressResponse GetAddressByPostalCode(PostalCodeRequest postalCode)
        {
            // Get Address By PostalCode Inquiry

            var response = new DTO.ExternalAPI.Response.AddressResponse();

            //Get Data from API

            response.ResponseCode= 200;
            response.ResponseMessage = "Response Message";

            if(response.ResponseCode == 200 )
            {
                response.Province = "Lorestan";
                response.City = "KhoramAbad";
                response.StreetDetail = new DTO.ExternalAPI.Embeded.StreetEmbeded
                {
                    Street = "Goldasht Sharghi",
                    Valley = "Parvin",
                    PostalCode = postalCode.PostalCode,
                    Pelak = "7"
                };
            }

            var responseInternal = _mapper.Map<AddressResponse>(response);
            return responseInternal;
        }
        
    }
}
