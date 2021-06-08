using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    interface IBank
    {
        public void ApplyFine();
        public void RetrieveCardAmount();
        public void BarAccount();
    }
}
