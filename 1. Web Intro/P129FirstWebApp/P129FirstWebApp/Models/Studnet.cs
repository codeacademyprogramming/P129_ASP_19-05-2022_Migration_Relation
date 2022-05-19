using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P129FirstWebApp.Models
{
    public class Studnet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public double Grade { get; set; }
        public int GroupId { get; set; }
    }
}
