using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class AuditEntity
    {
        public int CreatedAt { get; set; }
        public int UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
