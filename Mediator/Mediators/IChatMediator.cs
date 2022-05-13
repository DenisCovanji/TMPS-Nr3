using Mediator.Users;

namespace Mediator.Mediators
{
     interface IChatMediator
     {
          void SendMessageToAll(string message, UserBase from);
          void SendMessageToUser(string message, UserBase from, string toId);
     }
}
