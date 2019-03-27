using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Analytics.GFPatient;

namespace PainTrackerPT.Data.Analytics
{
    public class GFPatientGateway : IGFPatientGateway
    {
        private readonly PainTrackerPTContext _context;
        public GFPatientGateway(PainTrackerPTContext context)
        {
            _context = context;
        }

        public PainDiary SelectById(int? id)
        {
            List<Interference> interferenceList = new List<Interference>();
            List<Mood> moodList = new List<Mood>();
            List<Sleep> sleepList = new List<Sleep>();
            List<PainIntensity> painIntensityList = new List<PainIntensity>();

            //retrieve painDiary based on patient id
            PainDiary pain = _context.GFPainDiary.Find(id);

            //retrieve all records tied to patient pain diaries
            pain.Interference = retrieveInterferenceById(pain.PainDiaryID);
            pain.Mood = retrieveMoodById(pain.PainDiaryID);
            pain.Sleep = retrieveSleepById(pain.PainDiaryID);
            pain.PainIntensity = retrievePainIntensityById(pain.PainDiaryID);
            
            //pain.PainIntensity

            return pain;
        }

        public List<Interference> retrieveInterferenceById(int? id)
        {
            List<Interference> list = new List<Interference>();
            foreach (Interference entry in _context.GFInterference)
            {
                if (entry.PainDiaryID == id)
                {
                    list.Add(entry);
                }
            }
            return list;
        }

        public List<Mood> retrieveMoodById(int? id)
        {
            List<Mood> list = new List<Mood>();
            foreach (Mood entry in _context.GFMood)
            {
                if (entry.PainDiaryID == id)
                {
                    list.Add(entry);
                }
            }
            return list;
        }

        public List<PainIntensity> retrievePainIntensityById(int? id)
        {
            List<PainIntensity> list = new List<PainIntensity>();
            foreach (PainIntensity entry in _context.GFPainIntensity)
            {
                if (entry.PainDiaryID == id)
                {
                    list.Add(entry);
                }
            }
            return list;
        }

        public List<Sleep> retrieveSleepById(int? id)
        {
            List<Sleep> list = new List<Sleep>();
            foreach (Sleep entry in _context.GFSleep)
            {
                if (entry.PainDiaryID == id)
                {
                    list.Add(entry);
                }
            }
            return list;
        }
    }
}
