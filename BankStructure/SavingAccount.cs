using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankStructure
{
    internal class SavingAccount : BankAccount
    {
        public override float AddInterest()
        {
            Interest = Amount * 6 / 100;
            return Interest;
        }

    }
}
