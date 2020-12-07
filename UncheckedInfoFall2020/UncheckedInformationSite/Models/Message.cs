using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UncheckedInformationSite.Models
{
    public class Message
    {
        public int MessageID { get; set; }
        public string MessageTitle { get; set; }
        public string MessageText { get; set; }
        public DateTime MessageDate { get; set; }
        public User Messenger { get; set; }
    }
}
