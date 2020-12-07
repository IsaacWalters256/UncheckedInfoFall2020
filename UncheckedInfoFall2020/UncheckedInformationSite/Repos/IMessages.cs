using UncheckedInformationSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UncheckedInformationSite.Repos
{
    public interface IMessages
    {
        IQueryable<Message> Messages { get; }//Retreive
        void AddMessage(Message message);//create message
        Message GetMessageByTitle(string title);//special read
    }
}
