using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Patients
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Speciality { get; set; }
        public string AssignedPatients { get; set; }
       
       
        public Doctor()
        {

        }
        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public Doctor(int id, string name,string phone,string speciality)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Speciality = Speciality;
        }
        public override string ToString()
        {
            return "ID " + Id + "\nName: " + Name + "\nPhone:" + Phone + "\nSpeciality:" + Speciality + "\nAssigned Patients: "+AssignedPatients;
        }
       
        public void TakeDoctorDetailsFromAdmin()
        {
           
            
                
            int id;
            string phone;
            Console.WriteLine("Please give doctor's id");
            while (!Int32.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid entry. Please enter valid one");
            }
            Id = id;
            Console.WriteLine("Please enter name");
            Name = Console.ReadLine();
            
            Regex regex = new Regex(@"^\+65(6|8|9)\d{7}$");

            while (true)
            {
                Console.WriteLine("Please enter phone number");
                phone = Console.ReadLine();
                if (!regex.IsMatch(phone))
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


            Console.WriteLine("Please enter the speciality");
            Speciality = Console.ReadLine();
            AssignedPatients = "Patients- ";
            
           



        }
    }
}
