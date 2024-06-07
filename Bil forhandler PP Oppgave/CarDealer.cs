using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil_forhandler_PP_Oppgave
{
    internal class CarDealer
    {
        private List<Car> cars = new List<Car>();

        public void AddCar (Car car)
        {
            cars.Add(car);
        }

        public void ShowAllCars()
        {
            if (cars.Count == 0)
            {
                Console.WriteLine("No cars in shop");
            }
            else
            {
                Console.WriteLine("Cars in shop:");
                foreach (var car in cars)
                {
                    Console.WriteLine(car.ToString());
                }
            }
        }

        public void SearchCarsByYear(int startYear, int endYear)
        {
            var existingCars = cars.Where(b => b.ModelYear >= startYear && b.ModelYear <= endYear).ToList();

            if (existingCars.Count == 0)
            {
                Console.WriteLine($"No cars between year {startYear} and {endYear}.");
            }
            else
            {
                Console.WriteLine($"Cars between year {startYear} and {endYear}:");
                foreach (var car in existingCars)
                {
                    Console.WriteLine(car.ToString());
                }
            }
        }

        public void SearchCarByMinimumMilage(int minMilage)
        {
            var ExistingCars = cars.Where(car => car.Milage <= minMilage).ToList();

            if (ExistingCars.Count == 0)
            {
                Console.WriteLine($"No cars found with less or exactly {minMilage} km");
            }
            else
            {
                Console.WriteLine($"Cars with less or exactly {minMilage} km");
                foreach (var car in ExistingCars)
                {
                    Console.WriteLine(car.ToString());
                }
            }
        }

        public void SearchCarsByMaximumMilage(int maxMilage)
        {
            var ExistingCars = cars.Where(Car => Car.Milage >= maxMilage).ToList();

            if (ExistingCars.Count == 0)
            {
                Console.WriteLine($"No cars found with less or exactly {maxMilage} km");
            }
            else
            {
                Console.WriteLine($"Cars with more or exactly {maxMilage} km");
                foreach (var car in ExistingCars)
                {
                    Console.WriteLine(car.ToString());
                }
            }
        }

        public bool BuyCar(string regNumber)
        {
            
            var car = cars.FirstOrDefault(b => b.RegNumber == regNumber);
            if (car != null)
            {
                cars.Remove(car);
                return true;
            }
            else
            {
                Console.WriteLine("Bilen med det gitte registreringsnummeret finnes ikke.");
                return false;
            }
        }
    }
}
