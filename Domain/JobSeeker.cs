using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class JobSeeker:User
    {
        public int ExperienceYears { get; set; }
       public ICollection<Experience> Experiences { get; set; }
       
        public ICollection<HeadHunter> Employers { get; set; }
        
    }
}
