using Microsoft.AspNetCore.Mvc;
using MyFisrtNetCoreWebApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFisrtNetCoreWebApp.Controllers
{
    public class LocationController : Controller
    {
        ILog _log;
        public LocationController(ILog log)
        {
            _log = log;
        }
        public IActionResult Index()
        {
            _log.Info("Executing /Location");
            return View();
        }
    }
}
