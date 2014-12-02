using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezygnacja
{
    public class EventManager
    {
        private DBAdapter adapter;

        public EventManager(DBAdapter adapter)
        {
            this.adapter = adapter;
        }

        public List<EventGig> GetEventsForUser(User user)
        {
            return adapter.GetEventsForUser(user);
        }

        public void ResignFromEventForUser(User user, EventGig eventGig)
        {
            adapter.DeleteUserFromEvent(eventGig, user);
        }
    }
}
