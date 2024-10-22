namespace WTrafic_Management_Sy.Models
{
    public class Incident
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime DateReported { get; set; }
        public string Status { get; set; } // e.g., "Open", "Resolved"
    }
}
