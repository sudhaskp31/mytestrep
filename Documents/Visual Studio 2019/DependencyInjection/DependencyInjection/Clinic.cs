using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Clinic
    {
        private readonly IRepo _repo;
        public Clinic()
        {

        }
        public Clinic(IRepo repo)
        {
            _repo = repo;
        }
        public void PrintPatients()
        {
            List<Patient> patients = _repo.GetAll().ToList();
            foreach(var patient in patients)
            {
                Console.WriteLine(patient);
            }

        }
        public void UpdatePatient()
        {
            Console.WriteLine("UPDATION");
            Console.WriteLine("Please enter patient's id");
            int ID = Convert.ToInt32(Console.ReadLine());
            _repo.Update(ID);
            
        }
        public void DeletePatient()
        {
            Console.WriteLine("DELETION");
            Console.WriteLine("Please enter patient's id");
            int ID = Convert.ToInt32(Console.ReadLine());
            _repo.Delete(ID);

        }
        public void AddPatients()
        {
            string choice = "no";
            do
            {
                Patient patient = new Patient();
                patient.TakePatientDetailsFromUser();
                _repo.Add(patient);
                Console.WriteLine("Do you want to continue?");
                choice = Console.ReadLine().ToLower();

            } while (choice != "no");
        }
    }
}
