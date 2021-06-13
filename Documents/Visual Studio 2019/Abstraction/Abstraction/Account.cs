using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    
    class Account:IUser,IBank
    {
        public double Balance { get; set; }
        public string AccountStatus { get; set; }
        public Account()
        {
            Balance = 5000;
            AccountStatus = "Yet to be opened";
        }
        public void OpenAccount()
        {
            Console.WriteLine("Account Opened,Congrats!");
        }
        public void DoTransaction(double amount,bool creditStatus)
        {
            if (creditStatus)
            {
                Balance = Balance + amount;
            }
            else
            {
                Balance = Balance - amount;
            }
                
        }
        public void CloseAccount()
        {
            AccountStatus = "Closed";
            Console.WriteLine("Account is closed");
        }
        public void ApplyFine()
        {
            if(Balance<5000)
                Console.WriteLine("Fine is 250");
            else
                Console.WriteLine("No fine as of now");
        }
        public void RetrieveCardAmount()
        {
            Balance = Balance - 125.25;
            Console.WriteLine("Card amount debited");
        }
        public void BarAccount()
        {
            AccountStatus = "Barred";
            Console.WriteLine("***Your account is barred****");
        }
        public override string ToString()
        {
            return "Balance is " + Balance + "\nAccount Status " + AccountStatus;

        }



    }
}
