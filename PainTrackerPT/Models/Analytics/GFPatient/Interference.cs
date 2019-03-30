using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Analytics.GFPatient
{
    public class Interference
    {
        [Key]
        public int id { get; set; }

        [Column("Date")]
        public DateTime date;

        [Column("Description")]
        public string description { get; set; }

        [Column("Severity")]
        public int severity { get; set; }

        [Column("Duration")]
        public int duration { get; set; }

        [ForeignKey("PainDiary")]
        public int PainDiaryID { get; set; }




    }
}
