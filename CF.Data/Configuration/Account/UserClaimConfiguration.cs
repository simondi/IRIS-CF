using IRIS.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRIS.Data.Configuration
{
    internal class UserClaimConfiguration : EntityTypeConfiguration<UserClaim>
    {
        internal UserClaimConfiguration()
        {
            ToTable("UserClaim", DbSchemaName.ACCOUNT);
        }
    }
}
