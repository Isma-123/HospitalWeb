using System.ComponentModel.DataAnnotations;

namespace HospitalsWeb.cs.Models.Entities
{
    public class Doctor
    {

        [Key]
        public int DoctorId { get; set; }
        [Required]      
        public int HospitalId { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]  
        [StringLength(100)] 
        public string Especialidad { get; set; }

        [Required,StringLength(100)]    
        public string Telefono { get; set; }  

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

    }
}
