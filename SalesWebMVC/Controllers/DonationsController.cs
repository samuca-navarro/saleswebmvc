using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Donation donation)
        {
            _donationService.Insert(donation);
            return RedirectToAction(nameof(Index));
        }
    }
}