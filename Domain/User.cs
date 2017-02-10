using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public  class User
    {
        public int UserId { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public DateTime LastLogin { get; set; }
        public bool Locked { get; set; }
        public bool Expied { get; set; }
        public String LastName { get; set; }
        public String FirstName { get; set; }
        public DateTime Birthday { get; set; }
        public String ProffesinolaStatus { get; set; }
        public String Country { get; set; }
        public string gender { get; set; }
        public Sector Sector { get; set; }
        public ICollection<User> Friends { get; set; }
        public ICollection<Status> Status { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Message> Messages { get; set; }

    }
}
