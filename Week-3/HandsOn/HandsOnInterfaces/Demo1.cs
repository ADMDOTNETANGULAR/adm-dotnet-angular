using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInterfaces
{
    public interface  IManager
    {
        void ManageTeam();
    }
    public class TechLead:IEmployee, IManager //multiple inheritance of interfaces
    {
        public void Work()
        {
            Console.WriteLine("Leading the team and developing the application");
        }
        public string GetName()
        {
            return "Tech Lead Employee";
        }
        public void ManageTeam()
        {
            Console.WriteLine("Managing the team effectively");
        }
    }
    internal class Demo1
    {
    }
}
