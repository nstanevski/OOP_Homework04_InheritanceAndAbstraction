using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Define an abstract class Human holding a first name and a last name.
 * Define a class Student derived from Human that has a field faculty number (5-10 digits / letters).
 * Define a class Worker derived from Human with fields WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns the payment earned by hour by the worker. 
 * Define the proper constructors and properties for the classes in your class hierarchy.
 * Initialize a list of 10 students and sort them by faculty number in ascending order 
 * (use a LINQ query or the OrderBy() extension method). 
 * Initialize a list of 10 workers and sort them by payment per hour in descending order.
 * Merge the lists and then sort them by first name and last name.
 */


namespace _01_HumanStudentWorker
{
    class HumanStudentWorker
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Ivan", "Ivanov", "2015123456"));
            students.Add(new Student("Peter", "Petrov", "2013122459"));
            students.Add(new Student("Asen", "Petev", "2014122459"));
            students.Add(new Student("Stoyan", "Stoyanov", "2013122559"));
            students.Add(new Student("Stefan", "Stefanov", "2014123459"));
            students.Add(new Student("Donka", "Doneva", "2014123456"));
            students.Add(new Student("Stanka", "Staneva", "2011122459"));
            students.Add(new Student("Penka", "Peteva", "2015133459"));
            students.Add(new Student("Ivanka", "Ilieva", "2013122559"));
            students.Add(new Student("Radka", "Radeva", "2013123559"));

            IEnumerable<Student> orderedStudList =
           students
           .OrderBy(student => student.FacultyNumber);
            Console.WriteLine("==== Students, ordered by faculty number ====");
            foreach (Student student in orderedStudList)
            {
                Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.FacultyNumber);
            }

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Dimiter", "Dimitrov", 500, 8));
            workers.Add(new Worker("Iliya", "Ivanov", 505, 7));
            workers.Add(new Worker("Asen", "Asenov", 400, 6));
            workers.Add(new Worker("Svetoslav", "Svetlev", 305, 8));
            workers.Add(new Worker("Radoslav", "Radev", 600, 8));
            workers.Add(new Worker("Radostin", "Radkov", 545, 7));
            workers.Add(new Worker("Radomir", "Dimitrov", 800, 8));
            workers.Add(new Worker("Boris", "Bonev", 405, 7));
            workers.Add(new Worker("Dimiter", "Danchev", 850, 8));
            workers.Add(new Worker("Dragomir", "Donev", 605, 7));

            IEnumerable<Worker> orderedWorkersList =
           workers
           .OrderByDescending(worker => worker.MoneyPerHour());
            Console.WriteLine("==== Workers, ordered by hourly payment ====");
            foreach (Worker worker in orderedWorkersList)
            {
                Console.WriteLine("{0} {1} {2:c}", worker.FirstName, worker.LastName, worker.MoneyPerHour());
            }
            
            IEnumerable<Human> humans = 
                students.OfType<Human>()
                .Concat(workers.OfType<Human>())
                .OrderBy(x=>x.FirstName)
                .ThenBy(x=>x.LastName);
            Console.WriteLine("==== Humans, ordered by first and last name ====");
            foreach (Human human in humans)
            {
                Console.WriteLine("{0} {1}", human.FirstName, human.LastName);
            }
        }
    }
}
