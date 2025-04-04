using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateManager.BussinessLayer.Models
{
    public class State : AuditEntity
    {
        [Key]
        public int StateId { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
