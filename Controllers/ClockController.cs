using System;
using Microsoft.AspNetCore.Mvc;
namespace TimeDisplay.Controllers
{
    public class TimeController : Controller
    {
        [HttpGet("")]
        public ViewResult Clock()
        {
            DateTime TimeNow = DateTime.Now;
            string CurrentDate = TimeNow.ToString("MMMM dd yyyy");
            string CurrentTime = TimeNow.ToString("h:mm tt");
            ViewBag.Date = CurrentDate;
            ViewBag.Time = CurrentTime;
            return View();
        }
    }
}