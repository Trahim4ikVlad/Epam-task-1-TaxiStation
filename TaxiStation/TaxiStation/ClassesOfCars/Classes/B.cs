using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Specifications;

namespace TaxiStation.ClassesOfCars.Classes
{

    public class B:ClassOfCar
    {

        
        public override void Describe()
        {
            Console.WriteLine("Малый класс — популярный в Европе класс малогабаритных машин.");
        }
        public override string ToString()
        {
            return "Class - B";
        }
    }
}
