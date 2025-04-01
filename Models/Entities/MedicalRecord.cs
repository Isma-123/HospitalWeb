namespace HospitalsWeb.cs.Models.Entities
{
    public class MedicalRecord
    {
        public int MedicalRecordId { get; set; }
        public int PatientId { get; set; }
        public DateTime RecordDate { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }

    }
}
