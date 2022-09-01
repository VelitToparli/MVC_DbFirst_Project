using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_DbFirst_Project.Models;

namespace MVC_DbFirst_Project.Controllers
{
    public class FlightController : Controller
    {
        // GET: Flight

        DbFlightEntities db = new DbFlightEntities();

        public ActionResult CityList()
        {
            var values = db.TblCity.ToList();
            return View(values);
        }

        public ActionResult PassengerList()
        {
            var values = db.TblPassenger.ToList();
            return View(values);
        }
    }
}