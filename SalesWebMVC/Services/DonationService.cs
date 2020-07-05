using SalesWebMVC.Data;
using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Services
{
    public class DonationService
    {
        private readonly SalesWebMVCContext _context;
        
        public DonationService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public List<Donation> FindAll()
        {
            return _context.Donation.ToList();
        }

    }
}
