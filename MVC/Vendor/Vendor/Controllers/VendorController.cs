using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vendor.Data;
using Vendor.Models;

namespace Vendor.Controllers
{
    public class VendorController : Controller
    {
        private readonly DataContext _context;

        public VendorController(DataContext context)
        {
            _context = context;
        }

        public IActionResult List()
        {
            var vendors = _context.Vendors.ToList();
            return View(vendors);
        }



    }
}
