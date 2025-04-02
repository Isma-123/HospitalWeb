using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalsWeb.cs.Models.Entities
{


    [Table("Appointment")]
    public class Appointment
    {

        [Key]
        public int AppointmentId { get; set; }

        [Required]
        public int HospitalId { get; set; }  
        [Required]
        public int DoctorId { get; set; } 
        [Required]
        public int PatientId { get; set; } 
        [Required]
        public DateTime AppointmentDate { get; set; }
        [Required]
        [StringLength(50)]
        public string Comments { get; set; } 
    }
}
