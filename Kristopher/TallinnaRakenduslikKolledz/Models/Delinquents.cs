using System.ComponentModel.DataAnnotations;

namespace TallinnaRakenduslikKolledz.Models
{
    public class Delinquents
    {
        [Key]

        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Violation Violation { get; set; }

        public Subject Subject { get; set; }

        public string CurrentSituation { get; set; }


    }

    public enum Violation
    {
       Vandalising,NotFollowingRules,PhysicalHarm,Bullying,BeingLoud
    }

    public enum Subject
    {
        Student,Teacher,Other
    }
}
