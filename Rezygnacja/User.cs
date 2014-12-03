using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezygnacja
{
    public class User
    {
        private string name {get; set;}
        private Account account;

        public User()
        {
            name = "unknown";
            account = new Account(0);
        }

        public User(string name)
        {
            this.name = name;
            account = new Account(0);
        }

        public Account Account
        {
            get { return account; }
        }
    }
}
