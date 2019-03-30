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

        public IEnumerable<AnalyticsLog> SelectAll()
        {
            return _context.AnalyticsLog.ToList();
        }

        public AnalyticsLog SelectById(int? id)
        {
            return _context.AnalyticsLog.Find(id);
        }

        public AnalyticsLog Find(Guid? id)
        {
            return  _context.AnalyticsLog.FirstOrDefault(m => m.Id == id);
        }

        public void Insert(AnalyticsLog analyticsLog)
        {
            _context.Add(analyticsLog);

        }

        public void Delete(Guid id)
        {
            AnalyticsLog analyticsLog =  _context.AnalyticsLog.Find(id);
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
