using market.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using market.domian.entities;
using Microsoft.EntityFrameworkCore;

namespace market.Infrastructure.Core
{
    internal class BaseRepository
    {
        public class BaseRepository<T> where T : BaseEntity
        {
            protected readonly MarketContext _context;

            public BaseRepository(MarketContext context)
            {
                _context = context;
            }

            public async Task AddAsync(T entity)
            {
                await _context.Set<T>().AddAsync(entity);
                await _context.SaveChangesAsync();
            }

            public async Task<IEnumerable<T>> GetAllAsync()
            {
                return await _context.Set<T>().ToListAsync();
            }
        }
    }
}
