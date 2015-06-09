using System;
using System.Collections.Generic;

using _03_CompanyHierarchy.Persons.Classes;
using _03_CompanyHierarchy.Persons.Interfaces;
using _03_CompanyHierarchy.Persons.Tasks;

namespace _03_CompanyHierarchy
{
    class CompanyHierarchyTest
    {
        static void Main()
        {
            List<Person> persons = new List<Person>();

           Developer dev1 = new Developer("1234567890", "Ivan", "Iliev",
                1000.00m, Department.Production, null);
            dev1.AddProject(new Project("Project one", 
                DateTime.Now.AddDays(30), "This project aims..." ));
            dev1.AddProject(new Project("Project two",
                DateTime.Now.AddDays(50), "That project aims..."));
            Project prj3 = new Project("Project 3",
                DateTime.Now.AddDays(33), "That project aims...");
            dev1.AddProject(prj3);
            prj3.CloseProject();
            persons.Add(dev1);

            List<Sale> salesList = new List<Sale>();
            salesList.Add(new Sale("Prod 1", DateTime.Now.AddMonths(1), 123.45m));
            salesList.Add(new Sale("Prod 2", DateTime.Now.AddMonths(2), 423.45m));
            salesList.Add(new Sale("Prod 3", DateTime.Now.AddMonths(3), 1023.45m));
            SalesEmployee salesEmpl1 = new SalesEmployee("0987654321", "Peter", "Ivanov",
                2341.10m, Department.Sales, salesList);
            persons.Add(salesEmpl1);

            List<Employee> emplList = new List<Employee>();
            emplList.Add(dev1);
            emplList.Add(salesEmpl1);
            Manager man = new Manager("5432109876", "Gospodin", "Gospodinov", 3000.00m, Department.Sales, emplList);
            persons.Add(man);
            
            foreach (Person p in persons){
                Console.WriteLine(p);
            }    
        }
    }
}
