using System;
using System.Collections.Generic;
using System.Text;

namespace Understandingrelations
{
    class Cart
    {
        public void PullCart(Animal animal)
        {
            animal.eat();
            animal.move();
            animal.sleep();
        }
   static void Main(string[] args)
        {
            
            Cart cart = new Cart();
           Animal animal = new Donkey();
            cart.PullCart(animal);
            //animal.move();
            //animal.eat();
        }
    }
}
