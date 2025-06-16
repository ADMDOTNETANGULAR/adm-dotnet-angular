using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    internal class CarRepository : ICarRepository<Car>
    {
        public static List<Car> cars = new List<Car>();
        public void AddCar(Car car)
        {
            try
            {
                cars.Add(car);
            }
            catch (Exception)
            {

                throw;
            } //add car to the system
        }

        public void DeleteCar(int id)
        {
            try
            {
                Car car = cars.SingleOrDefault(c => c.ModelId == id);
                cars.Remove(car);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Car> GetAll()
        {
            return cars;
        }

        public Car GetCar(int id)
        {
            return cars.SingleOrDefault(c => c.ModelId == id);
        }

        public void UpdateCar(Car car)
        {
            try
            {
                for (int i = 0; i < cars.Count; i++)
                {
                    if (cars[i].ModelId == car.ModelId)
                    {
                        cars[i].Price = car.Price;
                        break;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
