using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace info
{
    public class Peoplelist
    {
        public static readonly List<people> peoples = new List<people>
        {
            new people()
            {
                Id = 2,
                Name = "Piip",
                Age = 21,
            },
            new people()
            {
                Id = 3,
                Name = "Tuut",
                Age = 18,
            }
        };
    };
}
