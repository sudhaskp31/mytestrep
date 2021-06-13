using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Understandingrelations
{
    class Phone
    {
        public string Color { get; set; }
        protected int passcode { get; set; }
        public void Ring()
        {
            Console.WriteLine("TRing");
        }
    }
}
