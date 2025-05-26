using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    public class Mercedes : Car
    {
        public override string Make => "Mercedes";

        public int Horsepower { get; set; }
    }
}
