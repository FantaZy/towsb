using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rezygnacja;

namespace RezygnacjaTests
{
    class MockDB : DBAdapter
    {
        List<KeyValuePair<EventGig, User>> usersGigs;

        public MockDB()
        {
            this.usersGigs = new List<KeyValuePair<EventGig, User>>();
        }

        public override void RecordData(EventGig gig, User user)
        {
            this.usersGigs.Add(new KeyValuePair<EventGig, User>(gig, user));
        }

        public override List<EventGig> GetEventsForUser(User user)
        {
            List<EventGig> ret = new List<EventGig>();
            foreach (var pair in usersGigs)
            {
                if (pair.Value == user)
                    ret.Add(pair.Key);
            }
            return ret;
        }

        public override void DeleteUserFromEvent(EventGig eventGig, User user)
        {
            var item = usersGigs.FirstOrDefault(x => x.Key == eventGig && x.Value == user);
            usersGigs.Remove(item);
        }
    }
}
