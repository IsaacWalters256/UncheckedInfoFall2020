using UncheckedInformationSite.Controllers;
using UncheckedInformationSite.Models;
using UncheckedInformationSite.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace MessageTests
{
    public class MessageTests1
    {
        [Fact]
        public void AddMessageTest()
        {
            // Set up
            var fakeRepo = new FakeMessageRepository();
            var controller = new BlogController(fakeRepo);
            var message = new Message() { MessageTitle = "loser", MessageText = "You suck", Messenger = new User() { Name = "Me" } };
            var currentDate = System.DateTime.Now.Date;
            // Put in fake database
            controller.SendMessage(message);
            // See if correct
            var retrievedMessage = fakeRepo.messages.ToList()[0];

            Assert.Equal(0, currentDate.CompareTo(retrievedMessage.MessageDate.Date));
            Assert.Equal(0, message.MessageTitle.CompareTo(retrievedMessage.MessageTitle));
        }

        [Fact]
        public void RetrieveMessageTest()
        {
            var fakeRepo = new FakeMessageRepository();
            var controller = new BlogController(fakeRepo);
            var message = new Message() { MessageTitle = "loser", MessageText = "You suck", Messenger = new User() { Name = "Me" } };
            var currentDate = System.DateTime.Now.Date;
            controller.SendMessage(message);
            Assert.Equal(message, fakeRepo.messages.ToList()[0]);
        }
    }
}
