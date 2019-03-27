using IRIS.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRIS.Data.Configuration
{
    internal class DataTableConfiguration : EntityTypeConfiguration<Document>
    {
        internal DataTableConfiguration()
        {
            ToTable("Document", DbSchemaName.DBO);
         //   ToTable("Inspection_PIL", DbSchemaName.DBO);
         //   ToTable("Inspection_Version", DbSchemaName.DBO);

        }
    }
}
