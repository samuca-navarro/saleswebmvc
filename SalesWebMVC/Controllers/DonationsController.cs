using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Services;

namespace SalesWebMVC.Controllers
{
    public class DonationsController : Controller
    {
        private readonly DonationService _donationService;

        public DonationsController(DonationService donationService)
        {
            _donationService = donationService;
        }

        public IActionResult Index()
        {
            var list = _donationService.FindAll();
            return View(list);
        }
    }
}