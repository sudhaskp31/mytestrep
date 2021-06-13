using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DependencyInjection
{
    class PatientRepo:IRepo//Implements the interface
    {
        List<Patient> patients;
        public PatientRepo()
        {
            patients = new List<Patient>();
        }
        public void Add(Patient patien)
        {
            patients.Add(patien);
        }
        public void Delete(int Id)
        {
           for (int i=0;i<patients.Count;i++)
            {
                if (patients[i].Id==Id)
                {
                    patients[i] = null;
                    Console.WriteLine("Patient's record is deleted");
                }
            }
        }
        public Patient Get(int Id)
        {
            for (int i=0;i<patients.Count;i++)
            {
               if (patients[i].Id==Id)
                {
                    return patients[i];
                }    

            }
            return null;
        }
        public IList<Patient> GetAll()
        {
            return patients;
        }
        public void Update(int Id)
        {
            Regex regex = new Regex(@"^\+65(6|8|9)\d{7}$");
            for (int i=0;i<patients.Count;i++)
            {
                if (patients[i].Id==Id)
                {
                    Console.WriteLine("Do you want to add medical condition yes/no?");
                    string choice = Console.ReadLine().ToLower();
                    if (choice=="yes")
                    {
                        Console.WriteLine("Please enter the medical conditions you wish to add");
                        string remarks = Console.ReadLine();
                        patients[i].Remarks += remarks;
                        Console.WriteLine("Medical conditions updated");
                    }
                    Console.WriteLine("Do you want to update phone number yes/no?");
                    string phonechoice = Console.ReadLine().ToLower();
                    if (phonechoice=="yes")
                    {
                       


                        while (true)
                        {
                            Console.WriteLine("Please enter phone number");
                            string phone = Console.ReadLine();
                            if (!regex.IsMatch(phone))
                            {
                                Console.WriteLine("Please enter valid phone number");
                                continue;

                            }
                            else
                            {
                                patients[i].Phone = phone;
                                Console.WriteLine("Phone number updated");
                                break;
                            }
                        }


                        

                    }
                }
            }

        }
    }
}
