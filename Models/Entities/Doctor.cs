namespace HospitalsWeb.cs.Models.Entities
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialization { get; set; }

        // Relación con el departamento
        public int DepartmentId { get; set; }
    }
}
