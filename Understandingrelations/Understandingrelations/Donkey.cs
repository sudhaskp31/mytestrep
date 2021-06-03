using System;
using System.Collections.Generic;
using System.Text;

namespace Understandingrelations
{
    class Donkey:Animal
    {
        public Donkey()
        {
           Name = "Donkey";
        }
        public override void move()
        {
            Console.WriteLine("I move slowly");
            Console.WriteLine(Name);
        }
    }
}
