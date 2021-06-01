using System;
struct books
{
    private string title;
    private string author;
    private string subject;
    private int book_id;

    public void getvalues(string tit,string auth,string sub,int bid)
    {
        title = tit;
        author = auth;
        subject = sub;
        book_id = bid;
    }

    public void display()
    {
        Console.WriteLine(title);
        
    }
    
};

namespace ConsoleApp8
{
    class Program
    {
        enum Days
        {
            Sunday, Monday, Tuesday
        };
        static void Main(string[] args)
        {
            // books b1, b2;
            books b1 = new books();
            books b2 = new books();
            /**b1.title = "New York Times";
            b1.author = "Allen";
            b1.subject = "Magazine";
            b1.book_id = 1;

            b2.title = "Vikatan";
            b2.author = "Bala";
            b2.subject = "Magazine";
            b2.book_id = 2;
            Console.WriteLine(b1.title);
            Console.WriteLine(b2.title);**/
            // 
            b1.getvalues("New York Times", "allen", "Magazine", 1);
            b2.getvalues("Vikatan", "Bala", "Magazine", 2);
            b1.display();
            b2.display();
            int d = (int)Days.Sunday;
            Console.WriteLine(d);
        }

           

       


      
       
          
        
            

        
    }
}
