using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rezygnacja;


namespace RezygnacjaTests
{
    [TestClass]
    public class RezygnacjaUnhappyPathTests
    {
        [TestMethod]
        public void RezygnacjaUnhappyPathTest_WhenUserResignsFromEventThatIsNotOnHisEventsListAErrorMessageIsAddedToMessageWindowAndAccountValueIsNotModified()
        {
            //GIVEN
            var user = new User("user1");
            IDBAdapter adapter = new MockDB();
            adapter.RecordData(new EventGig("Jazz Concert", 50), user, 50);

            var eventManager = new EventManager(adapter);
            var nonExistantEvent = new EventGig("Folk Concert", 125);
            int eventsCount = eventManager.GetEventsForUser(user).Count;
            int money = user.Account.Value;
            //WHEN
            eventManager.ResignFromEventForUser(user, nonExistantEvent);

            //THEN
            Assert.AreEqual(eventsCount, eventManager.GetEventsForUser(user).Count);
            Assert.AreEqual(money, user.Account.Value);
        }
    }
}
