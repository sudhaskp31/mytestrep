using System;

namespace Patients
{
    class Program
    {
        static void Main(string[] args)
        {
            // Patient pt = new Patient();
            //pt.TakePatientDetailsFromUser();
            
            Clinic clinic = new Clinic();
            
            clinic.AddPatients();
            clinic.AddDoctorDetails();
            clinic.PrintChoiceForUser();
            Console.ReadKey();

        }
        
    }
}
