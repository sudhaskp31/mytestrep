using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Dog:Animal
    {
        public override void Look()
        {
            Console.WriteLine("Have 4 legs and floppy ears");
        }
    }
}
