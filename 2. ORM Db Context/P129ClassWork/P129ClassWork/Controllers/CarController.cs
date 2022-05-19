using Microsoft.AspNetCore.Mvc;
using P129ClassWork.DAL;
using P129ClassWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P129ClassWork.Controllers
{
    public class CarController : Controller
    {
        //private readonly List<Car> _cars;
        private readonly AppDbContext _context;

        public CarController(AppDbContext context)
        {
            _context = context;

            //_cars = new List<Car>
            //{
            //    new Car{ Id = 1, Name= "F10", Year=2020, EngineType="Auto", BrandId= 1},
            //    new Car{ Id = 2, Name= "F30", Year=2010, EngineType="Mechanic", BrandId= 1},
            //    new Car{ Id = 3, Name= "G30", Year=2015, EngineType="Auto", BrandId= 1},
            //    new Car{ Id = 4, Name= "C190", Year=1990, EngineType="Auto", BrandId= 2},
            //    new Car{ Id = 5, Name= "SLS", Year=2022, EngineType="Auto", BrandId= 2},
            //    new Car{ Id = 6, Name= "CLK", Year=2022, EngineType="Auto", BrandId= 2},
            //    new Car{ Id = 7, Name= "Prado", Year=2010, EngineType="Auto", BrandId= 3},
            //    new Car{ Id = 8, Name= "Camery", Year=2020, EngineType="Auto", BrandId= 3},
            //    new Car{ Id = 9, Name= "Prius", Year=2013, EngineType="Mechanic", BrandId= 3},
            //};
        }

        public IActionResult Index(int? id)
        {
            List<Car> findingList = null;

            if (id != null)
            {
                findingList = _context.Cars.Where(c=>c.BrandId == id).ToList();
            }
            else
            {
                findingList = _context.Cars.ToList();
            }


            return View(findingList);
        }

        public IActionResult Detail(int? id)
        {
            Car car = _context.Cars.FirstOrDefault(c=>c.Id == id);
            return View(car);
        }
    }
}
