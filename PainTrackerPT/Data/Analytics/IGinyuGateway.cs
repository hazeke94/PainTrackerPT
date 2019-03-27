using PainTrackerPT.Models.Analytics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Data.Analytics
{
    interface IGinyuGateway
    {
        //implement CRUD for Logger
        Task<IEnumerable<AnalyticsLog>> SelectAllAsync();
        Task<AnalyticsLog> SelectByIdAsync(int? id);
        Task<AnalyticsLog> FindAsync(Guid? id);
        Boolean Exist(Guid? id);

        void Update(AnalyticsLog analyticsLog);
        void Delete(Guid id);
        void Insert(AnalyticsLog analyticsLog);

        void Save();
    }
}
