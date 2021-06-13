using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Patients
{
    public class Patient
    {
        /// <summary>
        /// declaring properties
        /// </summary>
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public string Remarks { get; set; }
        public string Gender { get; set; }
        public string AssignedDoctor { get; set; } 
        /// <summary>
        /// default constructor
        /// </summary>
        public Patient()
        {

        }
        /// <summary>
        /// parameterized construtor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        /// <param name="age"></param>
        /// <param name="remarks"></param>
        /// <param name="gender"></param>
       public Patient(int id, string name, string phone, int age, string remarks, string gender)//not using
        {
            Id = id;
            Name = name;
            Phone = phone;
            Age = age;
            Remarks = remarks;
            Gender = gender;
        }
       
        /// <summary>
        /// overriding ToString() method in Object class from which all classes inherit
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "ID: " +Id +"\nName: "+Name+"\nPhone: "+Phone+"\nAge: "+Age+"\nRemarks: "+Remarks+"\nGender: "+Gender+"\nAssigned Doctor: "+AssignedDoctor+"\n";
        }
        /// <summary>
        /// gets all the information of the patients from the user
        /// </summary>
        public void TakePatientDetailsFromUser()
        {
            int id,age;
            string phone,gender;
            Console.WriteLine("Please give patient id");
            while(!Int32.TryParse(Console.ReadLine(),out id))
            {
                Console.WriteLine("Invalid entry. Please enter valid one");
            }
            Id = id;
            Console.WriteLine("Please enter name");
            Name=Console.ReadLine();
            Console.WriteLine("Please enter age");
            while(!Int32.TryParse(Console.ReadLine(),out age))
            {
                Console.WriteLine("Invalid entry,please try again");
            }
            Age = age;
            Regex regex = new Regex(@"^\+65(6|8|9)\d{7}$");
            
            
            while(true)
            {
                Console.WriteLine("Please enter phone number");
                phone = Console.ReadLine();
                if(!regex.IsMatch(phone))
                        {
                    Console.WriteLine("Please enter valid phone number");
                    continue;

                }
                else
                {
                    Phone = phone;
                    break;
                }
            }
            
            
            Console.WriteLine("Please enter the health conditions");
            Remarks=Console.ReadLine();
            
            while(true)
            {
                Console.WriteLine("Please enter the gender Male/Female");
                gender = Console.ReadLine();
                if(! (gender.Equals("Male",StringComparison.CurrentCultureIgnoreCase) || (gender.Equals("Female",StringComparison.InvariantCultureIgnoreCase))))
                    {
                    Console.WriteLine("Invalid entry for Gender. Try again");
                    continue;
                    }
                else
                {
                    Gender = gender;
                    break;
                }

            }
            AssignedDoctor = "Not yet ";


        }
    }
}
