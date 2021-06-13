using System;
using System.Collections.Generic;
using System.Collections;
namespace Collections
{
    class Program
    {
        // ArrayList numbers = new ArrayList();
        List<double> numbers = new List<double>();
        public Program()
        {
            /*numbers.Add(100);
            numbers.Add(123.43);
            numbers.Add(123.3f);
           // numbers.Add("uuum");//not allowed--coz of -type safety
            double sum = 0;
            foreach(var item in numbers)
            {
                //sum = sum + Convert.ToInt32(item);//not necessary since all are double
                sum = sum + item;
            }
            Console.WriteLine($"Sum is {sum}");*/
        }
        void UnderstandingList()
        {
            List<string> names = new List<string>();
            names.Add("Ramu");
            names.Add("ABC");
            names.Add("Jill");
            names.Sort();
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Is the name Jill in list? " + names.Contains("Jill"));
            List<Employee> employees = new List<Employee>();
            Employee emp1 = new Employee(101, "ZRamu", 21);
            Employee emp2 = new Employee();
            emp2.Id = 102;
            emp2.Name = "Jill";
            emp2.Age = 32;
            Employee emp3 = new Employee
            {
                Id = 103,
                Name = "Jasmine",
                Age = 22
            };
            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);
            employees.Add(new Employee(104, "Rose", 18));//adding an object directly
            //employees.Sort();
            employees.Sort((e1, e2) => e1.Age.CompareTo(e2.Age));
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }
            if (new Employee(101, "ABC", 21).Equals(new Employee(101, "ABC", 21)))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            if (emp1.Equals(emp2))
                Console.WriteLine("Yes emp1 equals emp2");
            else
                Console.WriteLine("No emp1 not eq to emp2");
            Console.WriteLine("Is the employee Ramu in the list??? " + employees.Contains(new Employee(104, "Rose", 18)));
            Console.WriteLine("Enter the employee id to be found");
            int id = Convert.ToInt32(Console.ReadLine());
            Employee employee = employees.Find(emp => emp.Id == id);
            Console.WriteLine(employee);
        }
        void UnderstandingSet()
        {
            HashSet<int> set = new HashSet<int>();
            set.Add(100);
            set.Add(200);
            set.Add(100);
            set.Add(90);
            foreach(var item in set)
            {
                Console.WriteLine(item);
            }


        }
        void UnderstandingDictionary()
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            myDictionary.Add(101, "Ramu");
            myDictionary.Add(102, "Ramu");
            myDictionary.Add(103, "ABC");
           // myDictionary.Add(102, "null");
            Console.WriteLine("Does the collection contain the key 105? "+myDictionary.ContainsKey(105));
            Console.WriteLine("To access the value of the 102 "+myDictionary[102]);
            Console.WriteLine("================");
            foreach(var item in myDictionary.Keys)
            {
                Console.WriteLine(myDictionary[item]);
            }

        }
       void UnderstandStack()
        {
            Stack<Employee> employeeStack = new Stack<Employee>();
            employeeStack.Push(new Employee() { Id = 101, Name = "ABC", Age = 21 });
            employeeStack.Push(new Employee(102, "XYZ", 30));
            employeeStack.Push(new Employee());
            Console.WriteLine("Just to check the next retrievable item "+employeeStack.Peek());
            Console.WriteLine("The size of the stack before the pop is "+employeeStack.Count);
            foreach(var item in employeeStack)
            {
                Console.WriteLine(item);
            }

        }
        void UnderstandQueue()
        {
            Queue<Employee> employeeQueue = new Queue<Employee>();
            employeeQueue.Enqueue(new Employee(1, "Andy", 34));
            employeeQueue.Enqueue(new Employee() { Id = 2, Name = "Rose", Age = 26 });
            employeeQueue.Enqueue(new Employee(3, "Mary", 40));
            //Queue before dequeue
            Console.WriteLine("Queue before dequeue");
            foreach(var item in employeeQueue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Peek from the Employee queue is "+employeeQueue.Peek());
            employeeQueue.Dequeue();
            //Queue items after dequeue
            Console.WriteLine("Queue after dequeue");
            foreach (var item in employeeQueue)
            {
                Console.WriteLine(item);
            }

        }


        static void Main(string[] args)
        {
            Program program = new Program();
            //program.UnderstandingList();
          // program.UnderstandingDictionary();
            program.UnderstandStack();
          program.UnderstandQueue();
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
