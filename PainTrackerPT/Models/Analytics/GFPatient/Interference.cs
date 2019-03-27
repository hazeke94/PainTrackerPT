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

        public DateTime date;
        public string description { get; set; }
        public int severity { get; set; }
        public int duration { get; set; }

        [ForeignKey("PainDiary")]
        public int PainDiaryID { get; set; }




    }
}
