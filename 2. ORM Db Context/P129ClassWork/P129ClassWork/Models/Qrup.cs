using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P129ClassWork.Models
{
    public class Qrup
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Telebe> Telebes { get; set; }
    }
}
