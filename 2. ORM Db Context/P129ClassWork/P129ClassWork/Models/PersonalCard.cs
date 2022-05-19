using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P129ClassWork.Models
{
    public class PersonalCard
    {
        public int Id { get; set; }
        public string PIN { get; set; }

        public Human Human { get; set; }
    }
}
