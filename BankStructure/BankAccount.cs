using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankStructure
{
    abstract class BankAccount
    {
        public string AccountID { get; set; }
        public string Name { get; set; }
        public float Amount { get; set; }
        public float Credit { get; set; }
        public float Debit { get; set; }

        public float Interest { get; set; }

        public abstract float AddInterest();
    }
}
