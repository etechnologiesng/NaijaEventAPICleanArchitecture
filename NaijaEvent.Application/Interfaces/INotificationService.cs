using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NaijaEvent.Application.NEvents.Notification;

namespace NaijaEvent.Application.Interfaces
{
    public interface INotificationService
    {
        Task SendAsync(Message message);
      
    }
}
