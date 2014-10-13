using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Specifications;

namespace TaxiStation.ClassesOfCars.Classes
{
    public class E:ClassOfCar
    {
        
        public override void Describe()
        {
            Console.WriteLine("Бизнес-класс. Машины обладают просторным салоном и высоким уровнем стандартной комплектации.");
        }
        public override string ToString()
        {
            return "Class - E";
        }
    }
}
