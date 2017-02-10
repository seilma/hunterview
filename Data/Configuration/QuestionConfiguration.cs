using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configuration
{
    class QuestionConfiguration: EntityTypeConfiguration<Question>
    {
        public QuestionConfiguration()
        {
            HasMany(Q => Q.Responses).WithMany(R => R.Questions);
            HasRequired(Q => Q.Response).WithRequiredDependent(R => R.RightAnswer);
        //    HasRequired(Q => Q.Domaine).WithMany(D => D.Questions);
        }
    }
}
