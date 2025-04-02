using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalsWeb.cs.Models.Entities
{
    [Table("Hospital")]  

     
    public class Hospital
    {


        [Key]   
        public int HospitalId { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]  
        [StringLength(50)]  
        public string Direccion { get; set; }
        [Required]
        [StringLength(50)] 
        public string Telefono { get; set; }
        [Required,StringLength(50)]     
        public string Email { get; set; } 


    }
}
