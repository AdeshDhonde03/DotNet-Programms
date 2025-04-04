using System.ComponentModel.DataAnnotations;

namespace Vendor.Models
{
    public class State
    {
        [Key]
        public int StateId { get; set; }
      
        public string StateName { get; set; }
        //public virtual ICollection<City> Cities { get; set; }
        

    }
}
