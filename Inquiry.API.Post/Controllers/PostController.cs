using Inquiry.API.Post.DTO.InternalAPI.Request;
using Inquiry.API.Post.DTO.InternalAPI.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inquiry.API.Post.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class PostController : ControllerBase
    {
        public AddressResponse GetAdressByPostalCode(PostalCodeRequest postalCode) 
        { 

        }
    }
}
