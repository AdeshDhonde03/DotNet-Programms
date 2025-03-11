using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    public class Project : Devloper
    {
        public string ProjectName { get; set; }
        public string ProjectVersion { get; set; }
        public Project() 
        {
            Console.WriteLine("Project");
        
        }
    }
}
