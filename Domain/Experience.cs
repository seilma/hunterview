using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class Experience
    {
        public int ExperienceId { get; set; }
        public int Note { get; set; }
        public DateTime AddDate { get; set; }
        public bool Valid { get; set; }
        public Speciality Speciality { get; set; }
        public JobSeeker Jobseeker { get; set; }

    }
}
