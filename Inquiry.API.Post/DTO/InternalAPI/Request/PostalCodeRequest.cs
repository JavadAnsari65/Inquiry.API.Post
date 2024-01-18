using System.ComponentModel.DataAnnotations;

namespace Inquiry.API.Post.DTO.InternalAPI.Request
{
    public class PostalCodeRequest
    {
        [Required(ErrorMessage ="Voroodi Zaroori Ast")]
        [MaxLength(10)]
        public string PostalCode { get; set; }
    }
}
