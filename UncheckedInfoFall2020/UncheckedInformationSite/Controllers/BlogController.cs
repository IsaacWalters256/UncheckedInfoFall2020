using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UncheckedInformationSite.Models;
using UncheckedInformationSite.Repos;

namespace UncheckedInformationSite.Controllers
{
    public class BlogController : Controller
    {
        IMessages repo;

        public BlogController(IMessages r)
        {
            repo = r;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(Message model)
        {
            model.MessageDate = DateTime.Now;
            repo.AddMessage(model);
            return View(model);
        }

        public IActionResult Messages()
        {
            List<Message> messages = repo.Messages.ToList<Message>();
            //var messages = context.Messages.Include(message => message.Messager).ToList<Message>();

            return View(messages);
        }

        [HttpPost]
        public IActionResult Messages(string messageSender, DateTime messageDate)
        {
            var messages = (from m in repo.Messages
                            select m).ToList();
            if (messageSender != "" && messageSender != null)
            {
                messages = (from m in repo.Messages
                            where m.Messenger.Name == messageSender
                            select m).ToList();
            }
            else if (messageDate != DateTime.Now && messageDate != null)
            {
                messages = (from m in repo.Messages
                            where m.MessageDate == messageDate
                            select m).ToList();
            }
            return View(messages);
        }
    }
}
