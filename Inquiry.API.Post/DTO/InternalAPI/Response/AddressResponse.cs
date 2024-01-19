using Inquiry.API.Post.DTO.InternalAPI.Embeded;

namespace Inquiry.API.Post.DTO.InternalAPI.Response
{
    public class AddressResponse
    {
        public string Province { get; set; }
        public string City { get; set; }
        public StreetEmbeded StreetDetail { get; set; }
        
    }
}
