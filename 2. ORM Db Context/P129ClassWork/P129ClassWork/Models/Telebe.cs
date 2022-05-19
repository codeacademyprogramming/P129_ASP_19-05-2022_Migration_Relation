using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P129ClassWork.Models
{
    public class Telebe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int QrupId { get; set; }

        public Qrup Qrup { get; set; }
    }
}
