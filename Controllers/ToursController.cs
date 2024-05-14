using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using buyticketforbus.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;
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
            ViewBag.Drivers= await _tourService.drivers;
            return View();
        }


   }
}