using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.ModelCar;
using TaxiStation.ModelCar.EuropeanCars.Germany.BMW.ModelsBMW;

namespace TaxiStation
{
    public class Station:ICollection<Car>
    {
        private IList<Car> _cars = new List<Car>();
        
        private bool isRO = false;

        public double CalculateCost()
        {
            return _cars.Sum(car => car.GetCurrentPrice());
        }

        public void OrderByFuelTrack()
        {
           _cars = _cars.OrderBy(x => x.FuelConsumption.Track).ToList();
        }

        public void OrderByDescFuelTrack()
        {
            _cars = _cars.OrderByDescending(car => car.FuelConsumption.Track).ToList();
        }

        public void OrderByFuelCity()
        {
            _cars = _cars.OrderBy(car => car.FuelConsumption.City).ToList();
        }

        public void OrderByDescFuelCity()
        {
            _cars = _cars.OrderByDescending(car => car.FuelConsumption.City).ToList();
        }

        public void PrintAll()
        {
            foreach (var car in _cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
        public IEnumerable<Car> SearchOnFuel(double value)
        {
            return _cars.Where(car => car.FuelConsumption.City == value);
        }
        public IEnumerable<Car> SearchOnFuel(double value, uint delta)
        {
            return _cars.Where(car => Math.Abs(car.FuelConsumption.City - value) < delta);
        }
        public IEnumerable<Car> FindOnSpeed(double speed)
        {
            return _cars.Where(car => car.MaxSpeed == speed);
        }
        public IEnumerable<Car> FindOnSpeed(double speed, uint delta)
        {
            return _cars.Where(car => Math.Abs(car.MaxSpeed - speed) < delta);
        }
        public void Add(Car item)
        {
            if(!Contains(item))
            _cars.Add(item);
        }

        public void Clear()
        {
            _cars.Clear();
        }

        public bool Contains(Car item)
        {
            bool found = false;

            foreach (Car car in _cars)
            {
                if (car.Equals(item))
                {
                    found = true;
                }
            }

            return found;
        }

        public void CopyTo(Car[] array, int arrayIndex)
        {
            for (int i = 0; i < _cars.Count; i++)
            {

                array[i] = (Car)_cars[i];
            }
        }
        public int Count
        {
            get { return _cars.Count; }
        }
        public bool IsReadOnly
        {
            get { return isRO;  }
        }
       public  bool Remove(Car item)
        {
            bool result = false;

            for (int i = 0; i < _cars.Count; i++)
            {
                Car curCar = (Car)_cars[i];
                if (curCar.Equals(item))
                {
                    _cars.RemoveAt(i);
                    result = true;
                    break;
                }
            }
            return result;
        }
        
        public IEnumerator<Car> GetEnumerator()
        {
           return this._cars.GetEnumerator(); 
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}