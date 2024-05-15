using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using buyticketforbus.Models.TourViewModels;
using buyticketforbus.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace buyticketforbus.Controllers
{
    public class ToursController : Controller
    {
        private ITourService _tourService;
        public ToursController(ITourService tourService)
        {
            _tourService = tourService;
        }
        public async Task<IActionResult> Create()
        {
            var drivers = await _tourService.drivers();
            ViewBag.Drivers= new SelectList(drivers,"PersonelId","FullName");
            var hosts = await _tourService.hosts();
            ViewBag.Hosts = new SelectList(hosts,"PersonelId","FullName");
            return View();
        }
      


   }
}