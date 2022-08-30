using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            //10 employees list
            List<Employee> EmployeeList = new List<Employee>() {
            new Employee() {FirstName = "Shae", LastName = "Caltagirone", Id = 1 },
            new Employee() {FirstName = "Joe", LastName = "Marzett", Id = 2 },
            new Employee() {FirstName = "Rhonda", LastName = "Jenkins", Id = 3 },
            new Employee() {FirstName = "Aaron", LastName = "Dunning", Id = 4 },
            new Employee() {FirstName = "Lindsey", LastName = "Lohan", Id = 5 },
            new Employee() {FirstName = "Joe", LastName = "Star", Id = 6 },
            new Employee() {FirstName = "Betty", LastName = "White", Id = 7 },
            new Employee() {FirstName = "Aryn", LastName = "Stark", Id = 8 },
            new Employee() {FirstName = "Megan", LastName = "Trainer", Id = 9 },
            new Employee() {FirstName = "Miles", LastName = "Morales", Id = 10 }
            };

            //creates new list
            List<Employee> ListofJoes = new List<Employee>();

            //foreach loop finding first name joe
            foreach (Employee item in EmployeeList)
            {
                if (item.FirstName == "Joe")
                {
                    ListofJoes.Add(item);
                    Console.WriteLine(item.FirstName);
                    Console.ReadLine();
                }
            }

            //uses lambda
            List<Employee> JoeList = EmployeeList.Where(x => x.FirstName == "Joe").ToList();

            foreach(Employee employee1 in JoeList)
            {
                Console.WriteLine(employee1.FirstName);
                Console.ReadLine();
            }

            //Lambda listing employees with Id <5
            List<Employee> IdList = EmployeeList.Where(x => x.Id > 5).ToList();

            foreach (Employee employeeId in IdList)
            {
                Console.WriteLine(employeeId.Id);
                Console.ReadLine();
            }
        }
    }
}
