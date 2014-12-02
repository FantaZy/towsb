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
