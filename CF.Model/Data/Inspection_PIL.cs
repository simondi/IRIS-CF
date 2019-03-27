using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRIS.Model
{
    public class Inspection_PIL
    {
        public int Inspection_ID { get; set; }
        public DateTime DT_ENT { get; set; }
        public DateTime DT_CHG { get; set; }

        public int Inspection_Version_ID { get; set; }
        public virtual Inspection_Version Inspection_Version { get; set; }
        public int Inspection_Document_ID { get; set; }
        public virtual Document Inspection_Document { get; set; }

    }
}
