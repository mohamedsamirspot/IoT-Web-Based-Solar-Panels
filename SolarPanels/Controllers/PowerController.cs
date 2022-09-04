using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using SolarPanels.Models;
using SolarPanels.Models.Entites;

namespace SolarPanels.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PowerController : ControllerBase
    {
        private readonly DataContext _context;

        public PowerController(DataContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> PostSensorsReading(decimal c, decimal Alt, decimal Azi)
        {
            SensorsReading readings = new SensorsReading { SensorID = "1", current = c, AddedDate = DateTime.Now, Panel_ID = "1", Altitude = Alt, Azimuth = Azi };

            _context.SensorsReading.Add(readings);
            await _context.SaveChangesAsync();
            return CreatedAtAction("PostSensorsReading", new { readings });
        }

        // how to call it https://localhost:44335/api/power/postsensorsreading?c=5&alt=6&azi=2

        public IActionResult GetMode()
        {
            var q = (from p in _context.Panel select new { p.Current_Mode }).ToArray().Last();
            return Ok(q); // hwa kda hyrg3 fy shkl json
            // ok de 3shan el iactionreesult ok de ely hya response 200 mn el server y3ne
        }
        public IActionResult GetDirection()
        {
            var q = (from p in _context.ManualMode select new { p.Direction }).ToArray().Last();
            return Ok(q);
        }
    }
}