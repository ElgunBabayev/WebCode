using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webcode.DAL;
using webcode.Models;

namespace webcode.Controllers
{
    public class GroupController : Controller
    {

        private readonly AppDbContext db;
        public GroupController(AppDbContext _db)
        {
            db = _db;
        }

        private GroupCat GetGroupCatByGroupCatId(int id)
        {
            return db.GroupCats.FirstOrDefault(x => x.Id == id);
        }
        private List<Student> GetStudentsByGroupId(int GroupId)
        {
            return db.Students.Where(x => x.GroupId == GroupId).ToList();
        }
       
       


        public IActionResult Index()
        {
           
            
            GroupViewModel gvm = new GroupViewModel
            {
               Groups = db.Groups.ToList(),
               GroupCats = db.GroupCats.ToList(),
            };

            foreach (Group item in gvm.Groups)
            {
                item.Students = GetStudentsByGroupId(item.Id);
            }

            
            return View(gvm);
        }

        public IActionResult Details(int id)
        {
            
            Group group = db.Groups.FirstOrDefault(x => x.Id == id);
            group.Students = GetStudentsByGroupId(group.Id);
            group.GroupCats = GetGroupCatByGroupCatId(group.Id);
           
            return View(group);
        }

        public IActionResult Cabinet(int id)
        {
            Student stu = db.Students.FirstOrDefault(x => x.Id == id);

            stu.Group = db.Groups.FirstOrDefault(x => x.Id == stu.GroupId);
            stu.Group.GroupCats = db.GroupCats.FirstOrDefault(x => x.Id == stu.Group.GroupCatId);
            return View(stu);
        }


    }
}
