using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezygnacja
{
    public interface IDBAdapter
    {
        void RecordData(EventGig gig, User user, int startValue);

        List<EventGig> GetEventsForUser(User user);

        void DeleteUserFromEvent(EventGig eventGig, User user);

    }
}
