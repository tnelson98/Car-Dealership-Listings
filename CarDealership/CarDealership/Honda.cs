using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    public class Honda : Car
    {
        public override string Make => "Honda";

        public decimal BatteryCap { get; set; }
    }
}
