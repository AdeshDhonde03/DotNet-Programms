using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vendor.Models
{
    public class Vendors
    {
        [Key]
        public int VendorId { get; set; }
        [Required (ErrorMessage = "VendorName Is Required")]
        public string VendorName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress,ErrorMessage = "Email Is Required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Contact Number Is Required")]
        public string ContactNumber { get; set; }


        //[Required]
        //[ForeignKey("State")]
        //[DisplayName("State")]
        //public int StateId { get; set; }
        //public virtual State State { get; set; }

        [Required]
        [ForeignKey("City")]
        [DisplayName("City")]
        public int CityId { get; set; }
        public virtual  City city { get; set; }
     

    }
}
