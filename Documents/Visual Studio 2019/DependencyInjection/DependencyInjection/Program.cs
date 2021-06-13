using System;

namespace DependencyInjection
{
    class Program
    {
        IRepo repo;
        Clinic clinic;
        public Program()
        {
            repo = new PatientRepo();
            clinic = new Clinic(repo);
        }
        void DoClinicWork()
        {
            clinic.AddPatients();
            clinic.PrintPatients();
            clinic.UpdatePatient();
            clinic.PrintPatients();
            clinic.DeletePatient();
            clinic.PrintPatients();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            new Program().DoClinicWork();
            Console.ReadKey();
        }
    }
}
