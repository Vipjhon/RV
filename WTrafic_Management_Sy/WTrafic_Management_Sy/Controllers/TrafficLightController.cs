using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WTrafic_Management_Sy.Data;
using WTrafic_Management_Sy.Models;

namespace WTrafic_Management_Sy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrafficLightController : ControllerBase
    {
        private readonly TrafficManagementContext _context;

        public TrafficLightController(TrafficManagementContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrafficLight>>> GetTrafficLights()
        {
            return await _context.TrafficLights.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<TrafficLight>> PostTrafficLight(TrafficLight trafficLight)
        {
            _context.TrafficLights.Add(trafficLight);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetTrafficLights), new { id = trafficLight.Id }, trafficLight);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTrafficLight(int id, TrafficLight trafficLight)
        {
            if (id != trafficLight.Id) return BadRequest();

            _context.Entry(trafficLight).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
