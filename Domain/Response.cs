using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Response
    {
        [Key]
        public int ResponseId { get; set; }
        public String Content { get; set; }
        
        public  Question RightAnswer { get; set; }
        public  ICollection<Question> Questions { get; set; }
    }
}
