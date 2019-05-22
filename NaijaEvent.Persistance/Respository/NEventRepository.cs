using Microsoft.EntityFrameworkCore;
using NaijaEvent.Application.Interfaces;
using NaijaEvent.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NaijaEvent.Persistance.Respository
{
    class NEventRepository : INEventRepository
    {
        protected readonly NaijaEventContext _context;

        public NEventRepository(NaijaEventContext context)
        {
            _context = context;
        }

        public async Task Add(NEvent nEvent)
        {
            await _context.NEvents.AddAsync(nEvent);
        }

        public async Task<IEnumerable<NEvent>> FindAsync(Expression<Func<NEvent, bool>> predicate)
        {
        return  _context.NEvents.Where(predicate);
          
        }

        public async Task<NEvent> Get(Guid id)
        {
            return await _context.NEvents.SingleOrDefaultAsync(a => a.EventId == id);
        }

        public async Task<IEnumerable<NEvent>> GetAll()
        {
            return await _context.NEvents.ToListAsync();
        }

        public async Task Remove(NEvent nEvent)
        {
            _context.NEvents.Remove(nEvent);
        }
    }
}
