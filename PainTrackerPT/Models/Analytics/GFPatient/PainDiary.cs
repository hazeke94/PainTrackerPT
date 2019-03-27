using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Analytics.GFPatient
{
    public class PainDiary
    {
        [Key]
        public int PainDiaryID { get; set; }

        [ForeignKey("Patient")]
        public int PatientID { get; set; }
     

        public virtual ICollection<Interference> Interference { get; set; }
        public virtual ICollection<Mood> Mood { get; set; }
        public virtual ICollection<Sleep> Sleep { get; set; }
        public virtual ICollection<PainIntensity> PainIntensity { get; set; }    

    }
}
