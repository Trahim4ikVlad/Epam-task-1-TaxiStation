using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Specifications;

namespace TaxiStation.ClassesOfCars.Classes
{
    public class F:ClassOfCar
    {
        public override void Describe()
        {
            Console.WriteLine("Представительский класс, высший класс — модели этой группы в основном выполняют представительские функции.");
        }
        public override string ToString()
        {
            return "Class - F";
        }
    }
}
