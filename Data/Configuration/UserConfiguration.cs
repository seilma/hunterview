using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configuration
{
    class UserConfiguration: EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasMany(U => U.Messages).WithRequired(M => M.Sender);
            HasMany(U => U.Friends);
            
        }
    }
}
