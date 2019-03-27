using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Analytics;

namespace PainTrackerPT.Data.Analytics
{
    public class GinyuGateway : IGinyuGateway
    {
        private readonly PainTrackerPTContext _context;

        public GinyuGateway(PainTrackerPTContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AnalyticsLog>> SelectAllAsync()
        {
            return await _context.AnalyticsLog.ToListAsync();
        }

        public async Task<AnalyticsLog> SelectByIdAsync(int? id)
        {
            return await _context.AnalyticsLog.FindAsync(id);
        }

        public async Task<AnalyticsLog> FindAsync(Guid? id)
        {
            return await _context.AnalyticsLog.FirstOrDefaultAsync(m => m.Id == id);
        }

        public void Insert(AnalyticsLog analyticsLog)
        {
            _context.Add(analyticsLog);

        }

        public async void Delete(Guid id)
        {
            AnalyticsLog analyticsLog = await _context.AnalyticsLog.FindAsync(id);
            _context.AnalyticsLog.Remove(analyticsLog);
        }

        public void Update(AnalyticsLog analyticsLog)
        {
            _context.Update(analyticsLog);
        }

        public void Save()
        {
            _context.SaveChangesAsync();
        }

        public bool Exist(Guid? id)
        {
            return _context.AnalyticsLog.Any(e => e.Id == id);

        }
    }
}
