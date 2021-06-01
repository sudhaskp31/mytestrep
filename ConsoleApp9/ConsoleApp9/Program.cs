using System;

namespace ConsoleApp9
{
    class books
    {
        public string title;   // Length of a box
        public string author;  // Breadth of a box
        public string subject;
        public int book_id;
        public int year;
        public static int num;

        public books()
        {
            year = 2021;
        }
        public void count()
        {
            num++;
        }
        public int getnum()
        {
            return num;
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            books b1 = new books();
            books b2 = new books();
            b1.title = "New York Times";
            b1.author = "Allen";
            b1.subject = "Magazine";
            b1.book_id = 1;

            b2.title = "Vikatan";
            b2.author = "Bala";
            b2.subject = "Magazine";
            b2.book_id = 2;
            Console.WriteLine(b1.title);
            Console.WriteLine(b2.title);
            Console.WriteLine(b1.year);
            Console.WriteLine(b2.year);
            b1.count();
            b2.count();
            Console.WriteLine(b1.getnum());
            Console.WriteLine(b2.getnum());

        }
    }
}
