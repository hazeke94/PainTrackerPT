using PainTrackerPT.Models.Analytics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Data.Analytics
{
    public interface IGinyuGateway
    {
        //implement CRUD for Logger
        IEnumerable<AnalyticsLog> SelectAll();
        AnalyticsLog SelectById(int? id);
        AnalyticsLog Find(Guid? id);
        Boolean Exist(Guid? id);

        void Update(AnalyticsLog analyticsLog);
        void Delete(Guid id);
        void Insert(AnalyticsLog analyticsLog);

        void Save();
    }
}
