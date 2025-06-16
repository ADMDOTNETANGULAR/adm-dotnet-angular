using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        List<T> GetAll();
        void Add(T item);
        void Update(T item);
        void Delete(int id);
    }
    class Stundent
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
    class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class StudentRepo : IRepository<Stundent>
    {
        public void Add(Stundent item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Stundent Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Stundent> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Stundent item)
        {
            throw new NotImplementedException();
        }
    }
    class StaffRepository : IRepository<Staff>
    {
        public void Add(Staff item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Staff Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Staff> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Staff item)
        {
            throw new NotImplementedException();
        }
    }
    internal class Demo3
    {

    }
}
