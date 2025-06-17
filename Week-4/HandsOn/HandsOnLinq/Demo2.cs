using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    public record Employee(int Id, string Name, string Designation, DateTime JoinDate, double Salary, string Project);
    public record EmployeeDTO(int Id,string Name);
    internal class Demo2
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
            //fetch Shivas record
            var result = from e in list
                         where e.Id == 4456
                         select e;
            foreach (Employee e in result)
            {
                Console.WriteLine(e);
            }
            var employee=(from e in list
                          where e.Id==4456
                          select e).Single(); //Single() used when expression return 1 record
            //throws exception when expression return 0 or more records
            Console.WriteLine(employee);
            
            //return null to the result when expression retunr 0 records
            employee = (from e in list
                        where e.Id == 4459
                        select e).SingleOrDefault(); //here employee is null
            employee = (from e in list
                        where e.Id == 4459
                        select e).SingleOrDefault() ??
                        new Employee(2134, "Bhavani", "Sr Programmer", DateTime.Parse("5.30.2020"), 65000, "HelathCar");
            Console.WriteLine(employee);
            //retunr employees working as TeamLead
            var result1 = from e in list
                          where e.Designation == "TeamLead"
                          select e;
            //convert IEnumarable data to array
            Employee[] employees = (from e in list
                                    where e.Designation == "TeamLead"
                                    select e).ToArray();
            //convert IEnumarable data to List
            List<Employee> employees1= (from e in list
                                        where e.Designation == "TeamLead"
                                        select e).ToList();
            //return first record in the sequence
            Employee employee1 = (from e in list
                                  where e.Designation == "TeamLead"
                                  select e).First();
            //return last record in the sequence
            employee1 = (from e in list
                         where e.Designation == "TeamLead"
                         select e).Last();
            //return record using index
            employee1 = (from e in list
                         where e.Designation == "TeamLead"
                         select e).ElementAt(1);
            Console.WriteLine(employee1);
            //return required props from the object in the form of Anonymous type
            var result2 = (from e in list
                           where e.Project=="Ecomm"
                           select new { e.Id,e.Name});
            foreach(var item in result2)
                Console.WriteLine(item);
            //return required props from the object in the form of DTO type

            var result3= (from e in list
                          where e.Project == "Ecomm"
                          select new EmployeeDTO(e.Id,e.Name));
            foreach(var item in result3)
            Console.WriteLine($"Id:{item.Id} Name:{item.Name}");
            //sorting data
            var result4 = (from e in list
                           where e.Salary > 35000
                           orderby e.Name
                           select e);
            Console.WriteLine();
            foreach(var item in result4)
                Console.WriteLine(item);


        }
    }
}
