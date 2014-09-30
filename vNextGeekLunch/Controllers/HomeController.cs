using Microsoft.AspNet.Mvc;
using System;


namespace vNextGeekLunch
{
    /// <summary>
    /// Summary description for HomeController
    /// </summary>
    public class HomeController : Controller
    {
	    public HomeController()
	    {
		    //
		    // TODO: Add constructor logic here
		    //
	    }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Building()
        {
            return View();
        }


        public IActionResult Cat()
        {
            return View();
        }
    }
}