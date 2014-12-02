using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezygnacja
{
    public class DBAdapter
    {
        public virtual void RecordData(EventGig gig, User user)
        {
            throw new NotImplementedException();
        }

        public virtual List<EventGig> GetEventsForUser(User user)
        {
            throw new NotImplementedException();
        }

        public virtual void DeleteUserFromEvent(EventGig eventGig, User user)
        {
            throw new NotImplementedException();
        }
    }
}
