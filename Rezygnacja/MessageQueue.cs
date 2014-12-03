using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezygnacja
{
    public class MessageQueue
    {
        //could be observable
        //could by concurrent
        //could be done better
        private static Dictionary<User, Queue<string>> messages = new Dictionary<User,Queue<string>>();

        //this whole project could be done better
        //
        //actually, it is physical pain to write this.... BUT we have to deal with shitty reports. Shitty code then it is.

        public static void AddMessage(User user, String msg)
        {
            if (!messages.ContainsKey(user))
            {
                messages[user] = new Queue<string>();
            }
            messages[user].Enqueue(msg);
        }

        public static int MessageCount(User user)
        {
            if (messages.ContainsKey(user))
                return messages[user].Count;
            return 0;
        }
    }
}
