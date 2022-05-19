using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P129ClassWork.DAL;
using P129ClassWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P129ClassWork.Controllers
{
    public class BrandController : Controller
    {
        //private readonly List<Brand> _brands;
        private readonly AppDbContext _context;

        public BrandController(AppDbContext context)
        {
            _context = context;

            //_brands = new List<Brand>
            //{
            //    new Brand{Id=1,Name="BMW"},
            //    new Brand{Id=2,Name="Mercedes"},
            //    new Brand{Id=3,Name="Toyota"},
            //};
        }

        public IActionResult Index()
        {
            List<Brand> brands = _context.Brands.ToList();
            //List<Car> cars = new List<Car>();

            //foreach (Brand item in brands)
            //{
            //    List<Car> cars1 = _context.Cars.Where(c => c.BrandId == item.Id).ToList();
            //    cars.AddRange(cars1);
            //}

            //List<Qrup> qrups = _context.Qrups.Include(q=>q.Telebes).ToList();

            //Telebe telebe = _context.Telebes.Include(t=>t.Qrup).FirstOrDefault(t => t.Id == 2);

            //Human human = _context.Humen.Include(h => h.PersonalCard).FirstOrDefault(h=>h.Id == 1);
            PersonalCard personalCard = _context.PersonalCards.Include(h => h.Human).FirstOrDefault(h=>h.Id == 1);

            return Content(personalCard.Human.Name);

            return View(brands);
        }
    }
}
