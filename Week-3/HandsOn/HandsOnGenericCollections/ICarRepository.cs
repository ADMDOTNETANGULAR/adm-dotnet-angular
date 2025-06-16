using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    internal interface ICarRepository<T> where T : Car
    {
        //declare the operations perform on Car Model
        List<T> GetAll();
        T GetCar(int id);
        void AddCar(T car);
        void UpdateCar(T car);
        void DeleteCar(int id);
    }
}
