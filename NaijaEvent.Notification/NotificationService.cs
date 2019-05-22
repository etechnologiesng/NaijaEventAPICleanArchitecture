using NaijaEvent.Application.Interfaces;
using System;
using System.Threading.Tasks;

namespace NaijaEvent.Notification
{
    public class NotificationService : INotificationService
    {
      
        public NotificationService()
        {

        }
        public Task SendAsync(Message message)
        {
            return Task.CompletedTask;
        }
    }
}
