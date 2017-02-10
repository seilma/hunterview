using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configuration
{
    class JobConfiguration: EntityTypeConfiguration<Job>
    {
        public JobConfiguration()
        {
            HasRequired(j => j.Headhunter).WithMany(hh => hh.Jobs);
            HasMany(j => j.Domaines).WithMany(d => d.Jobs);
            //HasOptional(j => j.Coordination).WithRequired(coor => coor.Job);
        }
    }
}
