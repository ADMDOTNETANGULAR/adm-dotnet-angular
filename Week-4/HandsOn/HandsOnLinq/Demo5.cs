using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    internal class Demo5
    {
        static void Main()
        {
            List<Employee> list = new List<Employee>()
            {
                new Employee(4456,"Shivas","Programmer",DateTime.Parse("3.12.2025"),45000,"Ecomm"),
                 new Employee(2134,"Bhavani","Sr Programmer",DateTime.Parse("5.30.2020"),65000,"HelathCar"),
                  new Employee(7689,"Haritha","Programmer",DateTime.Parse("3.5.2024"),35000,"Ecomm"),
                   new Employee(5567,"Krishnan","Sr Programmer",DateTime.Parse("5.10.2022"),75000,"HelathCar"),
                    new Employee(0987,"Sandeep","Programmer",DateTime.Parse("1.20.2023"),35000,"Ecomm"),
                     new Employee(7765,"Kushi","Sr Programmer",DateTime.Parse("8.12.2020"),85000,"HelathCar"),
                      new Employee(1765,"Chetan","Programmer",DateTime.Parse("3.2.2020"),35000,"Ecomm"),
                       new Employee(9976,"Sree","TeamLead",DateTime.Parse("4.21.2020"),85000,"HelathCar"),
                        new Employee(4356,"Navya","TeamLead",DateTime.Parse("3.2.2020"),95000,"Ecomm"),
                         new Employee(8890,"Laxmi","TeamLead",DateTime.Parse("4.1.2020"),95000,"HelathCar"),
            };
            Employee e = list.Single(e => e.Id == 4456);
            var employees = list.Where(e => e.Designation == "Programmer");
            Employee[] employees1= list.Where(e => e.Designation == "Programmer").ToArray();
            List<Employee> employees2 = list.Where(e => e.Designation == "Programmer").ToList();
            e = list.Where(e => e.Designation == "Programmer").First();
            e = list.Where(e => e.Designation == "Programmer").Last();
            e = list.Where(e => e.Designation == "Programmer").ElementAt(2);
            //return anonymous object
            var result2 = list.Where(e => e.Designation == "Programmer").Select(e => new { e.Designation, e.JoinDate });
            //return in the form of DTO object
            var result3 = list.Where(e => e.Designation == "Programmer").Select(e => new EmployeeDTO(e.Id,e.Name));
            var r = (from e1 in employees
                             where e1.Id == 8890
                             select (e1.Id, e1.Name)).Single();
            //var (id, name) = r;
            var (id,name) = (from e1 in employees
                     where e1.Id == 8890
                     select (e1.Id, e1.Name)).Single();

        }
    }
}
