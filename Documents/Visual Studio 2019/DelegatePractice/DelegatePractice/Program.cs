using System;
using System.Collections;
using System.Collections.Generic;

namespace DelegatePractice
{
    public class Program
    {
        public delegate void MyDelegate(int n1, int n2);
       public  MyDelegate calDelAdd, calDelProd, calDelSub, calDelDiv;
        public Program()
        {

             calDelAdd = new MyDelegate(Add);
            calDelProd = new MyDelegate(Prod);
            calDelSub = delegate (int n1, int n2)
                  {
                      int sub = n1 - n2;
                      Console.WriteLine("The difference is " + sub);
                  };
            CallMethods(calDelAdd);
            CallMethods(calDelProd);
            CallMethods(calDelSub);
            //Lambda expression
            calDelDiv = (n1,n2)=>Console.WriteLine("The division result is "+(n1/n2));
            CallMethods(calDelDiv);
            //call by passing lambda directly
            CallMethods((n1, n2) => Console.WriteLine("The modulus is " + (n1 % n2)));
            Action<int, int> myaddDelaction = (n1, n2) => Console.WriteLine("The Action sum is "+(n1+n2));
            CallMethodsAnother(myaddDelaction);
            Func<int,int,int> myaddDelFunc= (n1,n2)=>n1 + n2;
            int result = CallMethodsAnother(myaddDelFunc);
            Console.WriteLine("Func add rsult is "+result);
            int num = 100;
            Predicate<int> checkPredicate = (n1) => (n1 > num);
            Console.WriteLine(checkPredicate(60));
                
        }
        void Add(int n1,int n2)
        {
            int sum = n1 + n2;
            Console.WriteLine("The sum is "+sum);
        }
        void Prod(int n1, int n2)
        {
            int prod = n1 * n2;
            Console.WriteLine("The prod is " + prod);

        }
        void CallMethods(MyDelegate methodRef)
        {
            methodRef(100,10);
        }
        void CallMethodsAnother(Action<int,int> methodRef)
        {
            methodRef(100, 10);
        }
        int CallMethodsAnother(Func<int, int,int> methodRef)
        {
            int res=methodRef(100, 10);
            return res;
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            // program.Add(4, 5);//without delegate
            // program.Prod(4, 5);//without delegate
            //program.calDelAdd(4, 5);//not efficient use of delegate
            //program.calDelProd(4, 5);//not efficient use of delegate
            

            
        }
    }
}
