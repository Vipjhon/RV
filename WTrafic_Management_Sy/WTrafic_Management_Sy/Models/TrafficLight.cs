namespace WTrafic_Management_Sy.Models
{
    public class TrafficLight
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string Status { get; set; } // e.g., "Red", "Green", "Yellow"
        public DateTime LastUpdated { get; set; }
    }
}
