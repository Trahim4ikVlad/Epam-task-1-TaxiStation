using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiStation.ModelCar.EuropeanCars.Germany.BMW.ModelsBMW
{
    public sealed class BmwX5:Bmw
    {
        public BmwX5(double price) : base(price)
        {
        }

        public override string ToString()
        {
            return "BMW - X5";
        }
    }
}
