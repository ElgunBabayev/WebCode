using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using webcode.DAL;
using webcode.Models;

namespace webcode.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext db;
        private readonly UserManager<AppUser> userManager;


        public HomeController(AppDbContext _db, UserManager<AppUser> _userManager)
        {
            db = _db;
            userManager = _userManager;
        }


        public IActionResult Index()
        {
            HomeViewModel hvm = new HomeViewModel
            {
                Banner = db.Banners.ToList(),
                GroupCats = db.GroupCats.ToList(),
                OurWork = db.OurWorks.ToList()
               
            };
            return View(hvm);
        }


        [HttpPost]
        public async Task<IActionResult> Contact(Contact contact)
        {
            await db.Contacts.AddAsync(contact);
            await db.SaveChangesAsync();    
            return RedirectToAction("index");
        }

    }

    

       
    
}
