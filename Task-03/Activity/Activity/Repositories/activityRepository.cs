using Activity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Activity.Repositories
{
    public class activityRepository : IactivityRepository
    {
        private readonly activityContext _context;

        public activityRepository(activityContext context)
        {
            _context = context;
        }

        public async Task<activity> Create(activity activity)
        {
            _context.Activity.Add(activity);
            await _context.SaveChangesAsync();
            return activity;
        }
        public async Task<IEnumerable<activity>> Get()
        {
            return await _context.Activity.ToListAsync();
        }

        public async Task<activity> Get(Guid id)
        {
            return await _context.Activity.FindAsync(id);
        }
    }
}
