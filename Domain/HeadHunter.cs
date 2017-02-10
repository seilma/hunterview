using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class HeadHunter:User
    {
        public String NomEntriprise { get; set; }
        public String position { get; set; }
        public ICollection<Job> Jobs { get; set; }
        public ICollection<JobSeeker> Employees { get; set; }


    }
}
