using Mediator.Users;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mediator.Mediators
{
     class ChatMediator : IChatMediator
     {
          private List<SimpleUser> _simpleUsers;

          public ChatMediator()
          {
               _simpleUsers = new List<SimpleUser>();
          }

          public void AddSimpleUserToChat(SimpleUser user)
          {
               _simpleUsers.Add(user);
          }

          public void SendMessageToAll(string message, UserBase from)
          {
               foreach (var user in _simpleUsers)
                    if (user != from)
                         user.ReceiveMessage(message, from.Id);
          }

          public void SendMessageToUser(string message, UserBase from, string toId)
          {
               var to = _simpleUsers.FirstOrDefault(x => x.Id == toId);

               if (to == null)
                    Console.WriteLine("No such user");
               else
                    to.ReceiveMessage(message, from.Id);
          }

          public void Quit(UserBase from)
          {
               _simpleUsers.Remove((SimpleUser)from);
          }

     }
}
