using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    interface IUser
    {
        public void OpenAccount();

        public void DoTransaction();

        public void CloseAccount();
        
    }
}
