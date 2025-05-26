using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    public class BMW : Car
    {
        public override string Make => "BMW";

        public string Engine {  get; set; }
    }
}
