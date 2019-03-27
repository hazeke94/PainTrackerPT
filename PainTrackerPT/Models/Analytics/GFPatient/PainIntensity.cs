using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Analytics.GFPatient
{
    public class PainIntensity
    {
        public DateTime date;
        public int painRating;
        public int painArea;
        public int duration;

        [ForeignKey("PainDiary")]
        public int PainDiaryID { get; set; }
    }
}
