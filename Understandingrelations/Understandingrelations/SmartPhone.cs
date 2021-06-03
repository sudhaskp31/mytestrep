using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Understandingrelations
{
    class SmartPhone:Mobile
    {
        public string MyApp { get; set; }
        public SmartPhone()
        {
            Color = "Metal";
        }
    }
}
