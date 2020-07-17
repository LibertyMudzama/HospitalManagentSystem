namespace HospitalManagementSystemShared.Models
{
    public class Bed
    {
        public int Id { get; set; }
        public int BedNumber { get; set; }
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }

    }
}