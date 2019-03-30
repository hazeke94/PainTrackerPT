using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Analytics.GFPatient
{
    public class Sleep
    {
        [Key]
        public int id { get; set; }

        [Column("Date")]
        public DateTime date;

        [Column("SleepHours")]
        public int sleepHours;

        [Column("ComfortLevel")]
        public int comfortLevel;

        [Column("Tiredness")]
        public int tiredness;

        [ForeignKey("PainDiary")]
        public int PainDiaryID { get; set; }
    }
}
