using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Specifications;

namespace TaxiStation.ClassesOfCars.Classes
{
    public class A:ClassOfCar
    {
        
        public override void Describe()
        {
            Console.WriteLine("Особо малый класс, супермини, городской автомобиль — самые маленькие автомобили, предназначенные для условий тесного города.");
        }
        public override string ToString()
        {
            return "Class - A";
        }

    }
}
