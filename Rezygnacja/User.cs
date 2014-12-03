using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezygnacja
{
    public class User
    {
        public class MoneyPurse
        {
            public enum Currency
            {
                PLN
            };
            public Currency OfCurrency;
            public int Value;
        }

        private string name {get; set;}
        public MoneyPurse Account { get; set; }

        public User()
        {
            name = "unknown";
        }

        public User(string name)
        {
            this.name = name;
            Account = new MoneyPurse();
        }
    }
}
