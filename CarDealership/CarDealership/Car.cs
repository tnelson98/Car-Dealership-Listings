using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    public abstract class Car
    {
        public abstract string Make { get; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int Age { get; set; }

        public decimal Price { get; set; }
    }
}
