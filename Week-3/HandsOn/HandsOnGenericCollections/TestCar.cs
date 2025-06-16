using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    internal class TestCar
    {
        static void Main()
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("1. Add Car");
                    Console.WriteLine("2. Get Car Details");
                    Console.WriteLine("3. Show All Cars");
                    Console.WriteLine("4. Update Car Details");
                    Console.WriteLine("5. Delete Car Details");
                    Console.WriteLine("6. Exit App");
                    Console.WriteLine("Enter Choice");
                    int ch = int.Parse(Console.ReadLine());
                    //create Carrepository object
                    CarRepository carRepository = new CarRepository();
                    switch (ch)
                    {
                        case 1:
                            {
                                Car car = new Car();
                                Console.WriteLine("Enter Model Id");
                                car.ModelId = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Model Name");
                                car.ModelName = Console.ReadLine();
                                Console.WriteLine("Enter Price");
                                car.Price = double.Parse(Console.ReadLine());
                                carRepository.AddCar(car);

                            }
                            break;
                        case 2:
                            {
                                Car car = null;
                                Console.WriteLine("Enter Model Id");
                                int id = int.Parse(Console.ReadLine());
                                car = carRepository.GetCar(id);
                                if (car == null)
                                {
                                    Console.WriteLine("Invalid Car Model");
                                }
                                else
                                {
                                    Console.WriteLine(car);
                                }
                            }
                            break;
                        case 3:
                            {
                                List<Car> cars = carRepository.GetAll();
                                foreach (Car car in cars)
                                {
                                    Console.WriteLine(car);
                                }

                            }
                            break;
                        case 4:
                            {
                                Car car = new Car();
                                Console.WriteLine("Enter Model Id");
                                car.ModelId = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Price");
                                car.Price = double.Parse(Console.ReadLine());
                                carRepository.UpdateCar(car);
                            }
                            break;
                        case 5:
                            {
                                Console.WriteLine("Enter Model Id");
                                int id = int.Parse(Console.ReadLine());
                                carRepository.DeleteCar(id);
                            }
                            break;
                        case 6:
                            {
                                Environment.Exit(0); //exit app
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
