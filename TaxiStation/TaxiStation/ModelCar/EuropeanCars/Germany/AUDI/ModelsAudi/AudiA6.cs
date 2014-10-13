using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiStation.ModelCar.EuropeanCars.Germany.AUDI.ModelsAudi
{
    public sealed class AudiA6:Audi
    {
        public AudiA6(double price) : base(price)
        {
        }

        public override string ToString()
        {
            return "AUDI - A6";
        }
    }
}
