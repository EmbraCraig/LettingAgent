using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LettingAgent.Models;
using LettingAgent.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace LettingAgent.Controllers
{
    public class EnquiryController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public EnquiryController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET ./enquiry/new
        public IActionResult New(int propertyId)
        {
            ViewData["Property"] = _context.Property.Find(propertyId);

            return View();
        }

        // POST ./enquiry/
        [HttpPost]
        public IActionResult Index(int propertyId, string enquiryText)
        {
            Enquiry enquiry = new Enquiry
            {
                UserId = User.FindFirstValue(ClaimTypes.NameIdentifier),
                PropertyId = propertyId,
                EnquiryText = enquiryText
            };
            _context.Enquiry.Add(enquiry);
            _context.SaveChanges();

            return Redirect("Enquiry/success");
        }

        // GET ./enquiry/success
        public IActionResult Success()
        {
            return View();
        }
    }
}
