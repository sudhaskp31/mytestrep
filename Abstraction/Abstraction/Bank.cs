using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Bank
    {
        public Bank()
        {
            Manager manager = new Manager();
            Account account = new Account();
            CustomerInteraction(manager,account);
            CustomerInteraction(account, manager);
            EmployeeInteraction(manager);
            UseManagerLunchTime(manager);
            UserInteraction(account);
            BankInteraction(account);
        }
        public void  CustomerInteraction(ICustomerManager customerManager)
        {
            Console.WriteLine("Customer Manager Time");

            customerManager.ApproveCustomerLoan();
            customerManager.SolveCustomerIssues();
        }
        public void CustomerInteraction(ICustomerManager customerManager,IBank account)
        {
            Console.WriteLine("Customer Manager Time");

            customerManager.ApproveCustomerLoan();
            customerManager.SolveCustomerIssues();
            Console.WriteLine("Account Closure");
            account.BarAccount();
            Console.WriteLine(account);
            
        }
        void CustomerInteraction(IUser account,ICustomerManager customerManager)
        {
            Console.WriteLine("New Customer");
            account.OpenAccount();
            Console.WriteLine(account);
            customerManager.ApproveCustomerLoan();
            account.DoTransaction(100000, true);
            Console.WriteLine(account);


            
        }
        public void EmployeeInteraction(IEmployeeManager employeeManager)
        {
            Console.WriteLine("Employee Manager Time");
            employeeManager.ConductAppraisals();
            employeeManager.ConductStaffMeeting();

        }
        public void UseManagerLunchTime(IHumanManager Humanmanager)
        {
            Console.WriteLine("Human Manager Time");
            Humanmanager.Eat();
            Humanmanager.Sleep();
        }
        public void UserInteraction(IUser userAccount)
        {
            userAccount.OpenAccount();
            userAccount.DoTransaction(100000,true);
            userAccount.CloseAccount();
        }
        public void BankInteraction(IBank bankAccount)
        {
            bankAccount.ApplyFine();
            bankAccount.RetrieveCardAmount();
            bankAccount.BarAccount();
        }
        static void Main(string[] a)
        {
            new Bank();
            new Account();
            Console.ReadKey();
        }

    }
}
