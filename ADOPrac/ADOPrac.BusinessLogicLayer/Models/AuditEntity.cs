using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOPrac.BusinessLogicLayer.Models
{
    public class AuditEntity
    {
        public int CreatedBy { get; set; }

        public int UpdatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }

        public int isActive { get; set; }
    }
}
