using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rezygnacja;

namespace RezygnacjaTests
{
    class MockDB : IDBAdapter
    {
        private Dictionary<User, List<EventGig>> data = new Dictionary<User, List<EventGig>>();


        public void RecordData(EventGig gig, User user, int startValue)
        {
            if (!data.ContainsKey(user))
            {
                user.Account.Value = startValue;
                data[user] = new List<EventGig>();
                data[user].Add(gig);
            }
            else
            {
                data[user].Add(gig);
            }
        }

        public List<EventGig> GetEventsForUser(User user)
        {
            if (data.ContainsKey(user))
                return data[user];
            return new List<EventGig>();
        }

        public bool DeleteUserFromEvent(EventGig eventGig, User user)
        {
            if (data.ContainsKey(user))
            {
                return data[user].Remove(eventGig);
            }
            return false;
        }
    }
}
