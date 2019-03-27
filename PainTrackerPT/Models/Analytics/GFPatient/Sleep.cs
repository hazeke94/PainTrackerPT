using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Analytics.GFPatient
{
    public class Sleep
    {
        public DateTime date;
        public int sleepHours;
        public int comfortLevel;
        public int tiredness;

        [ForeignKey("PainDiary")]
        public int PainDiaryID { get; set; }
    }
}
