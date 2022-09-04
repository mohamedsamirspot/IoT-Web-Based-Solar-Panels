using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SolarPanels.Models;
using SolarPanels.Models.Entites;

namespace SolarPanels.Controllers
{
    public class HomeController : Controller
    {

        private readonly DataContext _context;

        public HomeController(DataContext context)
        {
            _context = context;
        }
        public IActionResult HomePage()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Control()
        {
            return View();
        }
        public IActionResult Statistics()
        {
            var query = (from s in _context.SensorsReading orderby s.AddedDate descending select s).Take(10); //select s to select the entire object
            return View(query.ToList());
        }
        public IActionResult LiveReadings()
        {
            var query = (from s in _context.SensorsReading orderby s.AddedDate descending select s).Take(10); //select s to select the entire object
            return View(query.ToList());
        }
        public JsonResult Get_data()
        {
            var sr = (from s in _context.SensorsReading orderby s.AddedDate descending select new { s.current }).Take(10);
            return Json(sr.ToList());
        }

        public async Task<IActionResult> AutomaticControl()
        {
            Panel p = new Panel
            {
                Panel_ID = "1",
                Current_Mode = "A"
            };
            if (ModelState.IsValid)
            {
                _context.Add(p);
                await _context.SaveChangesAsync();
            }


            // decimal 3shan el table el so8yr el bta3 el alt w azi
            var query = (from s in _context.SensorsReading orderby s.AddedDate descending select s).Take(1);
            return View(query.ToList());

        }
        public async Task<IActionResult> ManualControl()
        {
            Panel p = new Panel
            {
                Panel_ID = "1",
                Current_Mode = "M"
            };
            if (ModelState.IsValid)
            {
                _context.Add(p);
                await _context.SaveChangesAsync();
            }
            return View();
        }

        //el function de 3shan aft7 el view bta3 el manualcontrol bs mn 8er ma a3de 3la el action bt3tha 3shan mro7sh azwd row fy el table el panel kol mra a3ml feha up or down
        public IActionResult ManualControlView()
        {
            return View("~/Views/Home/ManualControl.cshtml");
        }

        public async Task<IActionResult> UpDirection()
        {
            ManualMode m = new ManualMode
            {
                Direction="u"
            };
            if (ModelState.IsValid)
            {
                _context.Add(m);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ManualControlView));
                //aw momkn ashel el action de 5als ManualControlView w a3ml kda hna 3la tol 
                //return View("~/Views/Home/ManualControl.cshtml");
            }
            // w hna 
            // return View("~/Views/Home/ManualControl.cshtml");
            return View();
        }
        public async Task<IActionResult> RightDirection()
        {
            ManualMode m = new ManualMode
            {
                Direction = "r"
            };
            if (ModelState.IsValid)
            {
                _context.Add(m);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ManualControlView));
            }
            return View();
        }
        public async Task<IActionResult> LeftDirection()
        {
            ManualMode m = new ManualMode
            {
                Direction = "l"
            };
            if (ModelState.IsValid)
            {
                _context.Add(m);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ManualControlView));
            }
            return View();
        }
        public async Task<IActionResult> DownDirection()
        {
            ManualMode m = new ManualMode
            {
                Direction = "d"
            };
            if (ModelState.IsValid)
            {
                _context.Add(m);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ManualControlView));
            }
            return View();
        }
        public async Task<IActionResult> StopMoving()
        {
            ManualMode m = new ManualMode
            {
                Direction = "s"
            };
            if (ModelState.IsValid)
            {
                _context.Add(m);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ManualControlView));
            }
            return View();

        }

        //de y3ne lw 7bet ageb data mn el database 3la tol lw 3ayz y3ne bs el datatable hna 3mltha btre2a ashl fa msh m7tag de
        //public ActionResult GetList1()
        //{
        //    var sr = (from s in _context.SensorsReading select s);
        //     return Json(new { data = sr });
        //}

        public ActionResult GetList()
        {
            var sr = (from s in _context.SensorsReading orderby s.AddedDate descending select new { s.Altitude, s.Azimuth }).Take(1).ToList();
            return Json(new { data = sr });
        }

    }
}