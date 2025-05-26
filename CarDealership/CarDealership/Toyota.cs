using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    public class Toyota : Car
    {
        public override string Make => "Toyota";

        public int Mileage { get; set; }
    }
}
