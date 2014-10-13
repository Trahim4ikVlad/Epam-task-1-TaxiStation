using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiStation.ModelCar.EuropeanCars.Germany.Mercedes.ModelsMercedes
{
    public sealed class MerceresVito:MercedesBenz
    {
        public MerceresVito(double price) : base(price)
        {
        }

        public override string ToString()
        {
            return "Merceres Benz - Vito";
        }
    }
}
