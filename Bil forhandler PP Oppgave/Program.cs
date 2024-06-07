using System.Security.Cryptography.X509Certificates;

namespace Bil_forhandler_PP_Oppgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarDealer dealer = new CarDealer();

            dealer.AddCar(new Car("Toyota", 1997, "AB12345", 500000));
            dealer.AddCar(new Car("Lexsus", 2015, "VH69692", 80430));
            dealer.AddCar(new Car("BMW", 2022, "XY67890", 20000));
            dealer.AddCar(new Car("Audi", 2005, "CD67890", 10000));
            dealer.AddCar(new Car("Tesla", 2020, "XD83764", 30000));

            Console.WriteLine("Welcome to the dealership!");
                

            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Please select an option:" +
                                  "\n 1. Show all cars" +
                                  "\n 2. Find car after year" +
                                  "\n 3. Find car after maximum milage" +
                                  "\n 4. Find car after minimum milage" +
                                  "\n 5. Buy car" +
                                  "\n 6. Exit");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        dealer.ShowAllCars();
                        break;

                    case "2":
                        Console.WriteLine("write in minimum year");
                        int minYear = int.Parse(Console.ReadLine());
                        Console.WriteLine("write in maximum year");
                        int maxYear = int.Parse(Console.ReadLine());
                        dealer.SearchCarsByYear(minYear, maxYear);
                        break;

                    case "3":
                        Console.WriteLine("write maximum milage in km");
                        int maxMilage = int.Parse(Console.ReadLine());
                        dealer.SearchCarsByMaximumMilage(maxMilage);
                        break;

                    case "4":
                        Console.WriteLine("write minimum milage in km");
                        int minMilage = int.Parse(Console.ReadLine());
                        dealer.SearchCarByMinimumMilage(minMilage);
                        break;

                    case "5":
                        Console.WriteLine("Write the RegNumber of the car you want to buy");
                        string regNumber = Console.ReadLine();
                        bool bought = dealer.BuyCar(regNumber);
                        if (bought)
                        {
                            Console.WriteLine("Car is bought and removed from the shop");
                        }
                        break;

                    case "6":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Not an option, try again!");
                        break;
                }
            }
        }
    }
}
