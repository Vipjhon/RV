namespace WTrafic_Management_Sy.Data
{
    using Microsoft.EntityFrameworkCore;
    using WTrafic_Management_Sy.Models;

    public class TrafficManagementContext : DbContext
    {
        public DbSet<TrafficLight> TrafficLights { get; set; }
        public DbSet<Incident> Incidents { get; set; }

        public TrafficManagementContext(DbContextOptions<TrafficManagementContext> options) : base(options) { }
    }
}
