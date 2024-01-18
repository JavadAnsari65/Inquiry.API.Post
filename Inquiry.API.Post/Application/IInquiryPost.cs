using Inquiry.API.Post.DTO.InternalAPI.Request;
using Inquiry.API.Post.DTO.InternalAPI.Response;

namespace Inquiry.API.Post.Application
{
    public interface IInquiryPost
    {
        public AddressResponse GetAddressByPostalCode(PostalCodeRequest postalCode);
    }
}
