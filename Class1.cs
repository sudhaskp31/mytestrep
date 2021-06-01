using System;

public class Class1
{
	public Class1()
	{
	}
 class rectangle
    {
		double length;
		double width;

		public void getdata()
        {
			length = 4.5;
			width = 3.5;
        }
		public double GetArea()
        {
			return length * width;
        }
		public void display()
        {
			Console.WriteLine("Length:{0}", length);
			Console.WriteLine("Width:{0}", width);
			Console.WriteLine("Area:{0}",GetArea())
        }
    }
	public class m
	{
		public static void Main(string args[])
		{
			rectangle rect = new rectangle();
			rect.getData();
			rect.display();
			rect.GetArea();
			Console.ReadLine();
	
	}
	}
}
