using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
  public  class Job
    {
        public int JobId { get; set; }
        public Sector Sector { get; set; }
        public String Title { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime ExprerationDate { get; set; }
        public String Description { get; set; }
        public int Expertise { get; set; }
        public ICollection<Speciality> Specialities { get; set; }
        public State State { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime Duration { get; set; }
        public bool Valid { get; set; }
        public HeadHunter Headhunter { get; set; }
        


    }
    public enum State {

        Valide, Expired, Booked 
    }
    public enum JobType
    {
        Permanent,Training,Freelance

    }
   
}
