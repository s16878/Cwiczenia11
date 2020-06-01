namespace Cwiczenia11.Models
{
    public class Prescription
    {
        public int IdPrescription { get; set; }

        //...
        //[ForeignKey("Doctor")]
        public int IdDoctor { get; set; }
        public virtual Doctor1 Doctor { get; set; }
    }
}