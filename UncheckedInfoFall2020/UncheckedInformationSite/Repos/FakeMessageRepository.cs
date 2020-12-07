using UncheckedInformationSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UncheckedInformationSite.Repos
{
    public class FakeMessageRepository : IMessages
    {
        public List<Message> messages = new List<Message>();

        public IQueryable<Message> Messages { get { return (IQueryable<Message>) messages; } }

        public void AddMessage(Message message)
        {
            message.MessageID = messages.Count;
            messages.Add(message);
        }

        public Message GetMessageByTitle(string title)
        {
            throw new NotImplementedException();
        }
    }
}
