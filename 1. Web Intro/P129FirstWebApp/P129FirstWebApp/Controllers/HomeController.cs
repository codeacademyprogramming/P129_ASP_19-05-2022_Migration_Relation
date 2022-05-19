using Microsoft.AspNetCore.Mvc;
using P129FirstWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P129FirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Studnet> _studnets;
        private readonly List<Group> _groups;

        public HomeController()
        {

            _groups = new List<Group>
            {
                new Group{Id = 1,Name = "P129"},
                new Group{Id = 2,Name = "P128"},
                new Group{Id = 3,Name = "P224"},
                new Group{Id = 4,Name = "P225"},
            };

            _studnets = new List<Studnet>
            {
                new Studnet{Id=1,Name="Cavid",SurName="Alizade",Grade=85,GroupId = 1},
                new Studnet{Id=2,Name="Perviz",SurName="Alizade",Grade=80,GroupId = 1},
                new Studnet{Id=3,Name="Elgiz",SurName="Aliyev",Grade=70,GroupId = 1},
                new Studnet{Id=4,Name="Musa",SurName="Dadashov",Grade=85,GroupId = 1},
                new Studnet{Id=5,Name="Aliskandar",SurName="Qurbanov",Grade=82,GroupId = 1},
                new Studnet{Id=6,Name="Vasif",SurName="Aliyev",Grade=85,GroupId = 1},
                new Studnet{Id=7,Name="Murad",SurName="Abdullaye",Grade=85,GroupId = 2},
                new Studnet{Id=8,Name="Metin",SurName="Necefov",Grade=85,GroupId = 2},
                new Studnet{Id=9,Name="Sadiqxan",SurName="Qayxanov",Grade=85,GroupId = 3},
                new Studnet{Id=10,Name="Onur",SurName="Ismayilov",Grade=85,GroupId = 3},
            };


        }


        public IActionResult Index()
        {
            //if (id != null) return Json(studnets.Find(s => s.Id == id));

            ViewData["Name"] = "P129 Code";
            ViewBag.SurName = "Code Academy";

            TempData["Grade"] = 95;
            ViewBag.Students = _studnets;

            return View(_groups);
        }

        public IActionResult Studnet(int? id)
        {
            if (id == null) return BadRequest();

            List<Studnet> studnets = _studnets.FindAll(s => s.GroupId == id);


            return View(studnets);
        }








        //public IActionResult Index()
        //{
        //    if (1<0)
        //    {
        //        //JsonResult jsonResult = new JsonResult("P129 Json Resun");

        //        return Json(new { name="Hamid",surname="Mamamdov"});
        //    }
        //    else
        //    {
        //        //ViewResult viewResult = new ViewResult();
        //        //viewResult.ViewName = "P129FirstView";

        //        return View();
        //    }

        //    //ContentResult contentResult = new ContentResult();
        //    //contentResult.Content = "P129 Content Result";

        //    //return contentResult;

        //    //FileResult 

        //    //return 
        //}
    }
}
