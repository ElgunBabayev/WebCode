using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webcode.Areas.Admin.Models;
using webcode.DAL;

namespace webcode.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class DashboardController : Controller
    {
        private readonly AppDbContext db;
        public DashboardController(AppDbContext _db)
        {
            db = _db;
        }
        public async Task<IActionResult> Index()
        {
            DashboardViewModel dvm = new DashboardViewModel();
            dvm.Students = await db.Students.CountAsync();
            dvm.Groups = await db.Groups.CountAsync();
            return View(dvm);
        }
    }
}
