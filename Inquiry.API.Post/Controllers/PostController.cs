using Inquiry.API.Post.Application;
using Inquiry.API.Post.DTO.InternalAPI.Request;
using Inquiry.API.Post.DTO.InternalAPI.Response;
using Inquiry.API.Post.Infrastructure.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Inquiry.API.Post.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    
    public class PostController : ControllerBase
    {
        private readonly IInquiryPost _inquiryPost;
        private readonly LogService _logService;

        public PostController(IInquiryPost inquiryPost, LogService logService)
        {
            _inquiryPost = inquiryPost;
            _logService = logService;
        }

        [HttpPost]
        public ActionResult<AddressResponse> GetAdressByPostalCode(PostalCodeRequest postalCode) 
        {
            try
            {
                var addressResponse = _inquiryPost.GetAddressByPostalCode(postalCode);
                _logService.LogAction("GetAdressByPostalCode", JsonConvert.SerializeObject(postalCode), 
                    JsonConvert.SerializeObject(addressResponse),"OK");
                return Ok(addressResponse);
            }
            catch (Exception ex)
            {
                _logService.LogAction("GetAdressByPostalCode", JsonConvert.SerializeObject(postalCode), "Error", ex.Message);
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
