using System;
using TaxiStation.Specifications;

namespace TaxiStation.ClassesOfCars.Classes
{
    public class D:ClassOfCar
    {
       
        public override void Describe()
        {
            Console.WriteLine("Средний класс — средний или семейный класс.");
        }
        public override string ToString()
        {
            return "Class - D";
        }
    }
}
