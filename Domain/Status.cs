using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Status
    {
        public int StatusId { get; set; }
        public String Title { get; set; }
        public String Content { get; set; }
        public DateTime AddDate { get; set; }
        public bool Valid { get; set; }
        public JobSeeker JobSeeker { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
