using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.ClassesOfCars;
using TaxiStation.Specifications;
using TaxiStation.TypesOfBody;

namespace TaxiStation.ModelCar
{   
    public abstract class Car:IPassenger
    {
        public string RegistrationNumber { get; set; }
        private double _price;
        public string Color { get; set; }
        //число мест
        public int NumberOfSeats { get; set; }
        //максимальная скорость
        public double MaxSpeed { get; set; }
        //мощность двигателя
        public double EngineCapacity { get; set; }
        //габариты
        public Dimensions Dimensions { get; set; }
        //расход топлива
        public FuelConsumption FuelConsumption { get; set; }  
        //тип топлива
        public Fuel Fuel { get; set; }
        
        //год выпуска
        public DateTime ReleaseYear { get; set; }
        
        //тип кузова
        public TypeOfBody Type { get; set; }
        
        public ClassOfCar Class { get; set; }
        //наличие полного привода
        public bool IsFourWheelDrive { get; set; }


        public bool IsTechInspection
        {
            set { value = IsTechnicalInspection(); }
        }
        //дата прохождения тех осмотра
        public DateTime DatePassingTechInspection { get; set; }
        //дата оканчания действия тех осмотра
        public DateTime DateCloseTechInspection
        {
            set
            {
                value = NextTechInspection();
            }
        }
        //считает следующую дату прохождения тех осмотра
        private DateTime NextTechInspection()
        {
            DateTime next = DatePassingTechInspection.AddYears(GetAgeCar() < 5 ? 2 : 1);
            return next;
        }
        //есть ли техосмотр 
        private bool IsTechnicalInspection()
        {
            return NextTechInspection() < DateTime.Now;
        }
        
        public virtual void SetPrice(double price)
        {
            _price = price;
        }
        public double GetAgeCar()
        {
            double age = DateTime.Now.Year - ReleaseYear.Year;
            return age;
        }
        public virtual double GetCurrentPrice()
        {
            _price = _price - _price*GetAgeCar()*0.035;
            return _price;
        }

        public bool IsPassengerCar(bool isPassenger)
        {
            throw new NotImplementedException();
        }
    }
}
