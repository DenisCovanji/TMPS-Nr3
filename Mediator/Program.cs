using Mediator.Mediators;
using Mediator.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
     class Program
     {
          static void Main(string[] args)
          {
               ChatMediator chat = new ChatMediator();

               SimpleUser user1 = new SimpleUser(chat, "Tudor");
               SimpleUser user2 = new SimpleUser(chat, "Ion");
               SimpleUser user3 = new SimpleUser(chat, "Anatol");

               chat.AddSimpleUserToChat(user1);
               chat.AddSimpleUserToChat(user2);
               chat.AddSimpleUserToChat(user3);

               chat.Quit(user2);

               user1.SendMessageAll("hy");
               user2.SendMessageTo("Zdarova tolea", "Anatol");

               Console.ReadKey();
          }
     }
}
