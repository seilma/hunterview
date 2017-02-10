using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Comment
    {
        public int CommentId { get; set; }
        public String Content { get; set; }
        public DateTime AddDate { get; set; }
        public bool Valid { get; set; }
        public Status Status { get; set; }
        public JobSeeker User { get; set; }
       
    }
}
