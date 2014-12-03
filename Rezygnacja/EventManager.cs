using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezygnacja
{
    public class EventManager
    {
        private IDBAdapter adapter;

        public EventManager(IDBAdapter adapter)
        {
            this.adapter = adapter;
        }

        public List<EventGig> GetEventsForUser(User user)
        {
            return adapter.GetEventsForUser(user);
        }

        public void ResignFromEventForUser(User user, EventGig eventGig)
        {
            if (!adapter.DeleteUserFromEvent(eventGig, user))
                MessageQueue.AddMessage(user, "Nie można usunąć takiego eventu bo go nie ma");
        }
    }
}
