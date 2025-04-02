using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalsWeb.cs.Models.Entities
{

    [Table("Patient")]
    public class Patient
    {

        [Key]
        public int PatientId { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(50)]
        public DateTime? FechaNacimiento { get; set; }
        [Required]
        [StringLength(50)]
        public string Telefono { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }

    }
}
