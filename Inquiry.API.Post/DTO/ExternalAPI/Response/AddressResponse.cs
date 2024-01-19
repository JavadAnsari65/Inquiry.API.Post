using Inquiry.API.Post.DTO.ExternalAPI.Embeded;

namespace Inquiry.API.Post.DTO.ExternalAPI.Response
{
    public class AddressResponse
    {
        public string Province { get; set; }
        public string City { get; set; }
        public StreetEmbeded StreetDetail { get; set; }
        public int ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
    }
}
