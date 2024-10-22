using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WTrafic_Management_Sy.Data;
using WTrafic_Management_Sy.Models;

namespace WTrafic_Management_Sy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncidentController : ControllerBase
    {
        private readonly TrafficManagementContext _context;

        public IncidentController(TrafficManagementContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Incident>>> GetIncidents()
        {
            return await _context.Incidents.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Incident>> PostIncident(Incident incident)
        {
            _context.Incidents.Add(incident);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetIncidents), new { id = incident.Id }, incident);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateIncident(int id, Incident incident)
        {
            if (id != incident.Id) return BadRequest();

            _context.Entry(incident).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }

}
