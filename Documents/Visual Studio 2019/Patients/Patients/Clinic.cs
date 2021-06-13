using System;
using System.Collections.Generic;
using System.Text;

namespace Patients
{
    public class Clinic
    {
        /// <summary>
        /// takes number of patients
        /// </summary>
        Patient[] patients;
        Doctor[] doctors;
        public Clinic()
        {
            Console.WriteLine("Please enter how many patients");
            int size;
            while(!Int32.TryParse(Console.ReadLine(),out size))
            {
                Console.WriteLine("Invalid number of patients. Please enter the correct number");
            }
             patients = new Patient[size];
        }
        /// <summary>
        /// Taking patient details from user and assigning as many objects as number of patients(one patient=one object)
        /// </summary>
        public void AddPatients()
        {
            for (int i=0;i<patients.Length;i++)
            {
                patients[i] = new Patient();
                patients[i].TakePatientDetailsFromUser();
            }
        }
        /// <summary>
        /// Taking doctor details
        /// </summary>
        public void AddDoctorDetails()
        {
            Console.WriteLine("How many doctors details to be entered?");
            int size;
            while (!Int32.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("Invalid number,try again....");
            }
            doctors = new Doctor[size];
            for (int i = 0; i < size; i++)
            {
                doctors[i] = new Doctor();
                doctors[i].TakeDoctorDetailsFromAdmin();

            }

        }
        /// <summary>
        /// printing all details for doctor for admin purpose
        /// </summary>
        /// <param name="doctor"></param>
        public void PrintDoctorDetails(Doctor doctor)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine(doctor);
            Console.WriteLine("---------------------------");

        }
        /// <summary>
        /// printing details of doctors for assigning doctor to patient purpose
        /// </summary>
        /// <param name="doctor"></param>
        public void PrintDoctorDetailsForPatients(Doctor doctor)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Doctor's Name: "+doctor.Name);
            Console.WriteLine("Specialization:"+doctor.Speciality);
            
            Console.WriteLine("---------------------------");

        }
        /// <summary>
        /// printing all doctor details for admin purpose
        /// </summary>
        public void PrintAllDoctorDetails()
        {
            foreach (Doctor doctor in doctors)
            {
                PrintDoctorDetails(doctor);
            }
        }
        /// <summary>
        /// printing all details for doctors for assigning doctor to patient purpose
        /// </summary>
        public void PrintAllDoctorDetailsforPatients()
        {
            foreach (Doctor doctor in doctors)
            {
                PrintDoctorDetails(doctor);

            }
        }
        /// <summary>
        /// printing patient details(overriding ToString object. Instead ofprinting complete object name, it prints our  customized things
        /// </summary>
        /// <param name="patient"></param>
        public void PrintPatientDetails(Patient patient)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine(patient);
            Console.WriteLine("---------------------------");

        }
        /// <summary>
        /// print all patient details
        /// </summary>
        public void PrintAllPatientDetails()
        {
            foreach(Patient patient in patients)
            {
                PrintPatientDetails(patient);
            }
        }
        /// <summary>
        /// getting patient details based on their id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int FindPatientById(int id)
        {
            int index = -1;
            for (int i=0;i<patients.Length;i++)
            {
                if (id == patients[i].Id)
                {
                    index = i;
                    break;
                }

            }
            return index;
        }
        int GetPatientId()
        {
            int id;
            Console.WriteLine("Please enter the patient's id");
            while(!Int32.TryParse(Console.ReadLine(),out id))
            {
                Console.WriteLine("Invalid id. Please enter a correct one");
            }
            return id;
        }
        /// <summary>
        /// printing details of patient of a particular id
        /// </summary>
        public void PrintPatientById()
        {
            Console.WriteLine("Please enter Patient's id");
            int id = GetPatientId();
            int idx = FindPatientById(id);
            if (idx==-1)
            {
                Console.WriteLine("Id does not exists");
                return;
            }
            PrintPatientDetails(patients[idx]);
        }
        /// <summary>
        /// Assign patient to a doctor
        /// </summary>
        public void AssignPatientToDoctor(string doctorname)
        {
            Console.WriteLine("Please enter Patient's id");
            int id = GetPatientId();
            int idx = FindPatientById(id);
            if (idx == -1)
            {
                Console.WriteLine("No such ID exists");
                return;
            }
            patients[idx].AssignedDoctor = doctorname;
            AssignPatientListToDoctor(patients[idx], doctorname);

            
        }
        public void AssignPatientListToDoctor(Patient patient,string doctorname)
        {
            foreach(Doctor doctor in doctors)
            {
                if (doctor.Name.Equals(doctorname,StringComparison.CurrentCultureIgnoreCase))
                {
                    doctor.AssignedPatients+=" "+patient.Name;
                    
                }
            }
        }
        /// <summary>
        /// edit patient details based on id(only Remarks and phoneno allowed)
        /// </summary>
            public void EditPatientById()
        {
            Console.WriteLine("Please enter Patient's id");
            int id = GetPatientId();
            int idx = FindPatientById(id);
            if (idx==-1)
            {
                Console.WriteLine("No such ID exists");
                return;
            }
            PrintPatientDetails(patients[idx]);
            string choice;
            Console.WriteLine("Do you want to add more medical conditions?");
            choice = Console.ReadLine().ToLower();
            if (choice =="yes")
            {
                Console.WriteLine("Please enter the details you wish to add further to medical conditions");
                string data = Console.ReadLine();
                patients[idx].Remarks += data;
                Console.WriteLine("Medical Conditions updated");
                PrintPatientDetails(patients[idx]);
                return;
            }
            Console.WriteLine("Do you want to update the phone number?");
            choice = Console.ReadLine().ToLower();
            if (choice=="yes")
            {
                Console.WriteLine("Please enter the phone number");
                patients[idx].Phone = Console.ReadLine();
                Console.WriteLine("Phone number updated");
                PrintPatientDetails(patients[idx]);
                return;
            }
            Console.WriteLine("No updations were made..");

        }
        public void DeletePatient()
        {
            int patientid=GetPatientId();
            int index = FindPatientById(patientid);
            for (int i=0;i<patients.Length;i++)
            {
               if (patients[i].Id==patients[index].Id)
                {
                    patients[i] = null;
                    Console.WriteLine("Deleted the patient record");
                }
            }


        }
        /// <summary>
        /// giving choice for users to add patients,doctors,edit,assign doctor to patient
        /// </summary>
        public void PrintChoiceForUser()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("Please enter your choice");
                Console.WriteLine("1. Print all the patient's details");
                Console.WriteLine("2. Print any patient details");
                Console.WriteLine("3. Edit Patient details");
                Console.WriteLine("4. Print all doctors details for patient assignment");
                Console.WriteLine("5. Print all doctors details for admin purpose");
                Console.WriteLine("6. Delete a patient record");
                Console.WriteLine("0. Exit the application");
                while(!Int32.TryParse(Console.ReadLine(),out choice))
                {
                    Console.WriteLine("Invalid entry. Try again");
                }
                switch (choice)
                {
                    case 1:
                        PrintAllPatientDetails();
                        break;
                    case 2:
                        PrintPatientById();
                        break;
                    case 3:
                        EditPatientById();
                        break;
                    case 4:
                        PrintAllDoctorDetailsforPatients();
                        Console.WriteLine("Which doctor do you want to consult?");
                        string doctorname = Console.ReadLine();
                        AssignPatientToDoctor(doctorname);
                        
                        break;
                    case 5:
                        PrintAllDoctorDetails();
                        break;
                    case 6:
                        DeletePatient();
                        break;

                    case 0:
                        Console.WriteLine("Thank you . Bye");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }

            }
            while (choice != 0);

        }



        

    }
}
