using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankStructure
{
    internal class CurrentAccount : BankAccount
    {
        public override float AddInterest()
        {
            Interest = Amount * 8 / 100;
            return Interest;
        }
    }
}
