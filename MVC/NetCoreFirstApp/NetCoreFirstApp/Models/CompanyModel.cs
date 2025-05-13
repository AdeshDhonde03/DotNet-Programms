using System.ComponentModel.DataAnnotations;

namespace NetCoreFirstApp.Models
{
    public class CompanyModel
    {
        [StringLength(30,MinimumLength =5,ErrorMessage ="please Enter char between 5 to 30")]
        [Required(ErrorMessage ="Company Name is Required")]
        public string CompanyName { get; set; }
        public string GST { get; set; }
        public string Email { get; set; }
    }
}
