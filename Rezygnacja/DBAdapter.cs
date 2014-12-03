using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezygnacja
{
    public class DBAdapter : IDBAdapter
    {

        public void RecordData(EventGig gig, User user, int startValue)
        {
            throw new NotImplementedException();
        }

        public List<EventGig> GetEventsForUser(User user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUserFromEvent(EventGig eventGig, User user)
        {
            throw new NotImplementedException();
        }
    }
}
