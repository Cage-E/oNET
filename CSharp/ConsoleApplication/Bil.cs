using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Bil
    {
        public string Märke { get; set; }
        public int Modell { get; set; }
        public DateTime Birthday { get; set; }

        public string Slang { get { return Modell +" "+ Märke + "are"; } }

        public bool Myndig { get { return DateTime.Compare(Birthday.AddYears(18), DateTime.Now.Date) <= 0 ? true : false; } }    
    }
}
