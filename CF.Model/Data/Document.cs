using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IRIS.Model 
{
    public class Document
    {
        [Key]
        public int Document_ID { get; set; }
        public string FileStream  { get; set; }
        public DateTime DT_ENT { get; set; }
        public DateTime DT_CHG { get; set; }

    }
}
