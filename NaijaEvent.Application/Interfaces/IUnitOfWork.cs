using System;
using System.Collections.Generic;
using System.Text;

namespace NaijaEvent.Application.Interfaces
{
   public interface IUnitOfWork : IDisposable
    {
        
            INEventRepository nEvent { get; }      
            int Complete();
        }

    }
}
