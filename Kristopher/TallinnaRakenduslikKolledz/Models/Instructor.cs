using System.ComponentModel.DataAnnotations;

namespace TallinnaRakenduslikKolledz.Models
{
    public class Instructor
    {
        [Key]
        public int ID { get; set; }
        //
        [Required]
        [StringLength(50)]
        [Display(Name = "Perekonnanimi")]
        public string LastName { get; set; }
        //
        [Required]
        [StringLength(50)]
        [Display(Name = "Eesnimi")]
        public string FirstName { get; set; }
        //
        [Display(Name = "Õpetaja nimi")]
        public string FullName
        {
            get { return LastName + "," + FirstName; }
        }
        //
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Tööleasumiskuupäev")]
        public DateTime HireDate { get; set; }

        public ICollection<CourseAssigment>? CourseAssigments { get; set; }
        public OfficeAssignment? OfficeAssigment { get; set; }


        [Display(Name = "Rahvus")]
        public string? Nationality { get; set; }
        //
        [Display(Name = "Usk")]
        public string? Religion { get; set; }
        //
        [Display(Name = "Sugu")]
        public string? Gender   { get; set; }
        //
        [Display(Name = "Kogemus")]
        public string? Experience { get; set; }
        //
        [Display(Name = "Viimane Töökoht")]
        public string? LastJobPlace { get; set; }








    }
}
