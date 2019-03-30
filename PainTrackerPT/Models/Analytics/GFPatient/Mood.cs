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
        [Key]
        public int id { get; set; }

        [Column("Date")]
        public DateTime date;

        [Column("MoodType")]
        public int moodType { get; set; }

        [Column("Duration")]
        public int duration { get; set; }

        [ForeignKey("PainDiary")]
        public int PainDiaryID { get; set; }
    }
}
