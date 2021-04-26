using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yamed_Terminal_Service_GetPatient.Models
{
    public class Patient
    {
        public string FIO { get; set; }
        public DateTime Birthday { get; set; }
        public Sex SexPat { get; set; }
        public string NPolis { get; set; }
    }

    public enum Sex
    {
        Male = 1,
        Female = 2
    }
}
