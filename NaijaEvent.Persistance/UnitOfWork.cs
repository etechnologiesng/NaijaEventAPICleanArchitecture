using NaijaEvent.Application.Interfaces;
using NaijaEvent.Persistance.Respository;
using System;

namespace NaijaEvent.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        public INEventRepository nEvent => throw new NotImplementedException();

        private readonly NaijaEventContext _context;
        
        public UnitOfWork(NaijaEventContext context)
        {
            _context = context;
            NEvent = new NEventRepository(_context);
           
        }
public INEventRepository NEvent { get;  private set; }
       
        

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public int Complete()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
