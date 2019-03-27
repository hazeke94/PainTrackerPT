using PainTrackerPT.Models.Analytics.GFPatient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Data.Analytics
{
    interface IGFPatientGateway
    {
        PainDiary SelectById(int? id);
        List<Interference> retrieveInterferenceById(int? id);
        List<Mood> retrieveMoodById(int? id);
        List<Sleep> retrieveSleepById(int? id);
        List<PainIntensity> retrievePainIntensityById(int? id);

    }
}
