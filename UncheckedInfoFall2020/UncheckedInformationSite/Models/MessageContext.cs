using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UncheckedInformationSite.Models
{
    public class MessageContext : DbContext
    {
        public MessageContext(DbContextOptions<MessageContext> options) : base(options) { }
        public DbSet<Message> Messages { get; set; }
        public DbSet<User> User { get; set; }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var seedMessenger1 = new User { Name = "Emma Nioson" };
            modelBuilder.Entity<Message>().HasData(
                new Message
                {
                    MessageTitle = "Prince of Foxes",
                    MessageText = "I dont know what this means",
                    MessageDate = DateTime.Parse("11/1/2020"),
                    Messenger = seedMessenger1
                },
                new Message
                {
                    MessageTitle = "Ha ya right",
                    MessageText = "You are a looser lol git recked",
                    MessageDate = DateTime.Parse("11/2/2020"),
                    Messenger = new User { Name = "Yuion Nioson" }
                },
                new Message
                {
                    MessageTitle = "I am winner",
                    MessageText = "You lie! I am accually cool",
                    MessageDate = DateTime.Parse("11/2/2020"),
                    Messenger = seedMessenger1
                }
            );
        }*/
    }
}