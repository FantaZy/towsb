using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezygnacja
{
    public class Account
    {
        public int Funds { get; private set; }

        public Account(int val)
        {
            this.Funds = val;
        }
    }
}
