using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DIET.Models;
using Microsoft.AspNetCore.Authorization;

namespace DIET.Controllers
{
    public class PatientStartController : Controller
    {
        private readonly ILogger<PatientStartController> _logger;

        public PatientStartController(ILogger<PatientStartController> logger)
        {
            _logger = logger;
        }

        Patient pat=new Patient();
        public IActionResult Start()
        {
            return View();
        }
        public IActionResult MenuPatient(Patient patient)
        {
            pat = patient;
            return View(patient);
        }

        public IActionResult CardPatient(int? id)
        {
          pat  =pat.ReturnPatient(id);
            return View(pat);
        }




        //[Authorize]
        //public IActionResult Index()
        //{
        //    return Content(User.Identity.Name);
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
