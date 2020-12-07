using UncheckedInformationSite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UncheckedInformationSite.Repos
{
    public class MessageRepository : IMessages
    {
        private MessageContext context;
        //contructor
        public MessageRepository(MessageContext c)
        {
            context = c;
        }

        public IQueryable<Message> Messages { get { return context.Messages.Include(messages => messages.Messenger);}}

        public void AddMessage(Message message)
        {
            context.Messages.Add(message);
            context.SaveChanges();
        }

        public Message GetMessageByTitle(string title)
        {
            throw new NotImplementedException();
        }
    }
}
