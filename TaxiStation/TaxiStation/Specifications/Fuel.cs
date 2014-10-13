using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiStation.Specifications
{
    [Flags]
    public enum Fuel
    {
        Diesel = 0x01,
        Petrol = 0x02,
        Gas = 0x04
    }
}
