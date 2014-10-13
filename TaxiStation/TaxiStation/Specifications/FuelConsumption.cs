using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiStation.Specifications
{
    public struct FuelConsumption
    {
        public double City { get; set; }
        public double Track { get; set; }

        public FuelConsumption(double city, double track)
            : this()
        {
            this.City = city;
            this.Track = track;
        }
    }
}
