using System;
using TaxiStation.Specifications;

namespace TaxiStation.ClassesOfCars.Classes
{
    public class C:ClassOfCar
    {
        
        public override void Describe()
        {
            Console.WriteLine("Гольф-класс, компакт-класс — универсальные, относительно компактные, но более вместительные автомобили, также классифицируемые как «низший средний» класс.");
        }
        public override string ToString()
        {
            return "Class - C";
        }
    }
}
