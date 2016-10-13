using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalRDemo.Controllers
{
    public class GameHallController : Controller
    {
        // GET: GameHall
        public ActionResult KillingGame()
        {
            return View();
        }
    }
}