using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.Data.Entity;
using Domain;
using Data.Configuration;

namespace Data
{
   public class Contexte:DbContext
    {

        public Contexte():base("name=HunterViews")
        {
            //Database.SetInitializer<Contexte>(new InitializerContexte());
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Speciality> Specialities { get; set; }
        public virtual DbSet<Experience> Experiences { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
       // public virtual DbSet<Coordination> Coordination { get; set; }
        public virtual DbSet<Response> Responses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new JobConfiguration());
            //modelBuilder.Configurations.Add(new JobConfiguration());
            //modelBuilder.Configurations.Add(new JobSeeker());
            // modelBuilder.Conventions.Add(new DateTime2());
            modelBuilder.Entity<Response>().HasOptional(r => r.RightAnswer).WithRequired(q => q.Response);
            //  modelBuilder.Entity<Job>().HasOptional(r => r.Coordination).WithRequired(q => q.Job);
           // modelBuilder.Entity<JobSeeker>().HasOptional(js => js.Employers)
            
            modelBuilder.Entity<Status>().HasOptional(s => s.Comments);
            modelBuilder.Entity<Comment>().HasRequired(c => c.Status);
            
        }
    }
    public class InitializerContexte: DropCreateDatabaseIfModelChanges<Contexte>
    {
        protected override void Seed(Contexte context)
        {
         
           
        }
    }
}
