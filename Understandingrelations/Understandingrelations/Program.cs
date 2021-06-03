using System;

namespace Understandingrelations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Company comp = new Company();
            SmartPhone iPhone = new SmartPhone();
            Mobile mobile = new Mobile();
            Console.WriteLine(mobile.Color);
            iPhone.MyApp = "Excel";
            iPhone.Ring();
            Console.WriteLine(iPhone.Color);
            Console.WriteLine(iPhone.MyApp);
            Console.ReadKey();
            
            

        }
    }
}
