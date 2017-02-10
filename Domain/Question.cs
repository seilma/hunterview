using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class Question
    {

        public int QuestionId { get; set; }

        public String Content { get; set; }
        public Speciality Speciality { get; set; }
        public Response Response { get; set; }
        public ICollection<Response> Responses { get; set; }
    }

}
