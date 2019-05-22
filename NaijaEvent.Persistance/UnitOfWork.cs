using NaijaEvent.Application.Interfaces;
using NaijaEvent.Persistance.Respository;
using System;
using System.Threading.Tasks;

namespace NaijaEvent.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
       

        private readonly NaijaEventContext _context;
        
        public UnitOfWork(NaijaEventContext context)
        {
            _context = context;
            NEvent = new NEventRepository(_context);
           
        }
public INEventRepository NEvent { get;  private set; }


        public async Task CompleteAsync()
        {
             await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

  
    }
}
