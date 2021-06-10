using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Manager:ICustomerManager,IEmployeeManager,IHumanManager
    {

        public void Eat()
        {
            Console.WriteLine("Eat food");
        }
        public void Sleep()
        {
            Console.WriteLine("seven * snoozeeeee");
        }
        public void ConductStaffMeeting()
        {
            Console.WriteLine("Conducts meeting");
        }
        public void ApproveCustomerLoan()
        {
            Console.WriteLine("Loan approved");
        }
        public void ConductAppraisals()
        {
            Console.WriteLine("Conducts Appraisals");
        }
        public void SolveCustomerIssues()
        {
            Console.WriteLine("Solveing Customer Issues");
        }
    }
}
