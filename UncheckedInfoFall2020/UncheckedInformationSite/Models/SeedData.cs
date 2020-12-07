using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UncheckedInformationSite.Models
{
    public class SeedData
    {
    }
}

/*
SeedData.cs in Models
using UncheckedInformationSite.Controllers;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UncheckedInformationSite.Models;

namespace UncheckedInformationSite.Models
{
    public class SeedData
    {
        MessageContext context;
        public SeedData(MessageContext c)
        {
            context = c;
        }

        //public static void Seed(IApplicationBuilder app)
        public void Seed()
        {
            //MessageContext context = app.ApplicationServices.GetRequiredService<MessageContext>();
            //context.Database.EnsureCreated(); //would create a db if it didnt exist
            if (!context.Messages.Any()) //temp comment to add data, this stops it from add new data if data already exists
            {
                var seedMessenger1 = new User { Name = "Emma Nioson" };
                Message message = new Message
                {
                    MessageTitle = "Prince of Foxes",
                    MessageText = "I dont know what this means",
                    MessageDate = DateTime.Parse("11/1/2020"),
                    Messenger = seedMessenger1
                };
                context.Messages.Add(message);

                message = new Message
                {
                    MessageTitle = "Ha ya right",
                    MessageText = "You are a looser lol git recked",
                    MessageDate = DateTime.Parse("11/2/2020"),
                    Messenger = new User { Name = "Yuion Nioson" }
                };
                context.Messages.Add(message);
                message = new Message
                {
                    MessageTitle = "I am winner",
                    MessageText = "You lie! I am accually cool",
                    MessageDate = DateTime.Parse("11/2/2020"),
                    Messenger = seedMessenger1
                };
                context.Messages.Add(message);
                context.SaveChanges(); // save all the data
            }
        }
    }
}*/