using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiStation.Specifications
{
    public struct Dimensions
    {
        public double Length { get; set; }
        public double Width { get; set; }
        

        public Dimensions(double length, double width)
            : this()
        {
            this.Length = Length;
            this.Width = width;
        }
    }
}
