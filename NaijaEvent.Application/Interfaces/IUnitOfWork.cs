using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NaijaEvent.Application.Interfaces
{
   public interface IUnitOfWork : IDisposable
    {
        
            INEventRepository NEvent { get; }      
            Task CompleteAsync();
        }

    }

