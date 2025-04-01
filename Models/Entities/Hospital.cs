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
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }
    }
}
