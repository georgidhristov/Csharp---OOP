using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3CompanyHierarchy
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Employee persons
            Employee employeePerson1 = new Employee("43001", "Petar", "Petrov", 1200, "Production");
            Employee employeePerson2 = new Employee("43023", "Ivan", "Petrov", 1300, "Accounting");
            Employee employeePerson3 = new Employee("43045", "Stefan", "Ivanov", 1150, "Sales");
            Employee employeePerson4 = new Employee("43098", "Radoslav", "Georgiev", 1500, "Marketing");

            //List of Employee Persons
            List<Employee> listOfEmployee = new List<Employee>();
            listOfEmployee.Add(employeePerson1);
            listOfEmployee.Add(employeePerson2);
            listOfEmployee.Add(employeePerson3);
            listOfEmployee.Add(employeePerson4);
            //Manager - holds a set of employees under his command.
            Person managerPerson = new Manager("6663", "Stanislav", "Dimitrov", listOfEmployee);
            Console.WriteLine("Manager: " + managerPerson.ToString());

            Console.WriteLine("\nEmployees:");
            foreach (var item in listOfEmployee)
            {
                Console.WriteLine(item);
            }

            //Regular employee
            Person regularEmployeePerson = new RegularEmployee("00014", "Ivan", "Ivanov");
            Console.WriteLine("\nRegular Employee: " + regularEmployeePerson.ToString());

            //Products
            Sales product1 = new Sales("Laptop Lenovo G560", new DateTime(2010), 600m);
            Sales product2 = new Sales("Laptop Asus X553MA-XX432D", new DateTime(2013), 500.98m);
            Sales product3 = new Sales("Laptop Gaming Asus ROG G551JW-CN319D", new DateTime(2015), 2199.99m);

            //List of sales
            List<Sales> listOfSalse = new List<Sales>();
            listOfSalse.Add(product1);
            listOfSalse.Add(product2);
            listOfSalse.Add(product3);

            //Sales employee - holds a set of sales.
            Person salesEmployeePerson = new SalesEmployee("00224", "Lubomir", "Lubenov", listOfSalse);
            Console.WriteLine("\nSales Employee: " + salesEmployeePerson.ToString());

            //Projects
            Projects project1 = new Projects("Conference Management App", new DateTime(2015, 11, 27), "Build new app", "open");
            Projects project2 = new Projects("Reports & Dashboards", new DateTime(2015, 05, 02), "upgrade system", "open");
            project2.CloseProject();

            //List of projects
            List<Projects> listOfProjects = new List<Projects>();
            listOfProjects.Add(project1);
            listOfProjects.Add(project2);

            //Developer
            Person developerPerson = new Developer("66613", "Georgi", "Georgiev", listOfProjects);
            Console.WriteLine("\nDeveloper: " + developerPerson);

            //Finally... Customer
            Person customerPerson = new Customer("413103", "Pesho", "Petrov", 2199.99m);
            Console.WriteLine("\nCustomer: " + customerPerson );
        }
    }
}
