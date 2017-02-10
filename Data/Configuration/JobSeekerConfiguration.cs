using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configuration
{
    class JobSeekerConfiguration: EntityTypeConfiguration<JobSeeker>
    {
        public JobSeekerConfiguration()
        {
            HasMany(js => js.Experiences).WithRequired(E => E.Jobseeker);
            HasMany(js => js.Status).WithRequired(S => S.JobSeeker);
         //   HasMany(js => js.Comments).WithRequired(C => C.Jobseeker);
          //  HasMany(js => js.Coordinations).WithMany(Coor => Coor.Jobseekers);
            //HasRequired(p => p.categ).WithMany(c => c.Products);
            //HasMany(p => p.Providers).WithMany(pr => pr.Products).Map(n => n.ToTable("prov"));
            //Property(pro => pro.Name).HasColumnName("Nom");
            //Map<Biolagical>(b => b.ToTable("bio"));

        }
    }
}
