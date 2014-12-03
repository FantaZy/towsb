using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rezygnacja;

namespace RezygnacjaTests
{
    [TestClass]
    public class RezygnacjaHappyPathTests
    {
        [TestMethod]
        public void TestHappyPath_ShowEventsForUser()
        {
            //GIVEN
            var user = new User("user1");
            DBAdapter adapter = new MockDB();
            var gig = new EventGig("Jazz Concert", 50);
            adapter.RecordData(gig, user);
            
            var eventManager = new EventManager(adapter);
            
            //WHEN
            var events = eventManager.GetEventsForUser(user);
            //THEN
            Assert.AreEqual(1, events.Count);
            Assert.AreEqual(gig, events[0]);
        }

        [TestMethod]
        public void TestHappyPath_WhenUserResignedFromEventThisEventIsNoLongerInHisEventsList()
        {
            //GIVEN
            var user = new User("user1");
            DBAdapter adapter = new MockDB();
            adapter.RecordData(new EventGig("Jazz Concert", 50), user);

            var eventManager = new EventManager(adapter);
            //WHEN
            var events = eventManager.GetEventsForUser(user);
            eventManager.ResignFromEventForUser(user, events[0]);

            var updatedEvents = eventManager.GetEventsForUser(user);

            //THEN
            Assert.AreEqual(0, updatedEvents.Count);
            
        }

        [TestMethod]
        public void TestHappyPath_WhenUserResignedFromEventSuccessfullyMoneyIsReturnedToUsersAccount()
        {
            //GIVEN
            var user = new User("user1");
            DBAdapter adapter = new MockDB();
            adapter.RecordData(new EventGig("Jazz Concert", 50), user);

            var eventManager = new EventManager(adapter);
            //WHEN
            var events = eventManager.GetEventsForUser(user);
            eventManager.ResignFromEventForUser(user, events[0]);

            //THEN
            Assert.AreEqual(50, user.Account.Funds);
        }
    }
}
