using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Analytics.GFPatient
{
    public class Mood
    {
        public DateTime date;
        public int moodType { get; set; }
        public int duration { get; set; }

        [ForeignKey("PainDiary")]
        public int PainDiaryID { get; set; }
    }
}
