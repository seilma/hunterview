using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class Message
    {
        public int MessageId { get; set; }
        public String Object { get; set; }
        public String Title { get; set; }
        public String Content { get; set; }
        public DateTime SendDate { get; set; }
        public bool Seen { get; set; }
        public User Sender { get; set; }
        public User Receiver { get; set; }
        public bool Deleted { get; set; }
    }
}
