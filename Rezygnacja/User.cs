using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezygnacja
{
    public class User
    {
        public string name;

        public User()
        {
            name = "unknown";
        }

        public User(string name)
        {
            this.name = name;
        }
    }
}
