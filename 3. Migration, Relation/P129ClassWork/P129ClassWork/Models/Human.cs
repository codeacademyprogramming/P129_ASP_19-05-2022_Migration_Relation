using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P129ClassWork.Models
{
    public class Human
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PersonalCardId { get; set; }

        public PersonalCard PersonalCard { get; set; }

    }
}
