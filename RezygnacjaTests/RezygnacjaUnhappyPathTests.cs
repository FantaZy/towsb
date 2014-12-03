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
            DBAdapter adapter = new MockDB();
            adapter.RecordData(new EventGig("Jazz Concert", 50), user);

            var eventManager = new EventManager(adapter);
            var nonExistantEvent = new EventGig("Folk Concert", 125);
            int eventsCount = eventManager.GetEventsForUser(user).Count;
            int money = user.Account.Funds;
            //WHEN
            string message = eventManager.ResignFromEventForUser(user, nonExistantEvent);

            //THEN
            Assert.AreEqual("error", message);
            Assert.AreEqual(money, user.Account.Funds);
        }
    }
}
