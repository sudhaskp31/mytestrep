using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Animal
    {
        public abstract void Look();
        public virtual void Eat()
        {
            Console.WriteLine("Eat..eat");
        }
        public void Sleep()
        {
            Console.WriteLine("zzzz..");
        }
    }
}
