using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Analytics.GFPatient
{
    public class PainIntensity
    {
        [Key]
        public int id { get; set; }

        [Column("Date")]
        public DateTime date;

        [Column("PainRating")]
        public int painRating;

        [Column("PainArea")]
        public int painArea;

        [Column("Duration")]
        public int duration;

        [ForeignKey("PainDiary")]
        public int PainDiaryID { get; set; }
    }
}
