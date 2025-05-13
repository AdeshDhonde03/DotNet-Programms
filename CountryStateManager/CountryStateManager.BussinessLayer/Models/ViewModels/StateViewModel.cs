using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateManager.BussinessLayer.Models.ViewModels
{
    public class StateViewModel : AuditEntity
    {
        public int StateId { get; set; }
        public int CountryId { get; set; }
        public string? CountryName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
