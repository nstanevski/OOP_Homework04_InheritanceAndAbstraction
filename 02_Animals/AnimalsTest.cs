using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Create an abstract class Animal holding name, age and gender.
 * Create a hierarchy with classes Dog, Frog, Cat, Kitten and Tomcat. Dogs, frogs and cats are animals. 
 * Kittens are female cats and Tomcats are male cats. Define useful constructors and methods. 
 * Define an interface ISoundProducible which holds the method ProduceSound(). 
 * All animals should implement this interface. The ProduceSound() method should produce 
 * a specific sound depending on the animal invoking it (e.g. the dog should bark).
 * Create an array of different kinds of animals and calculate the average age 
 * of each kind of animal using LINQ.
 */

namespace _02_Animals
{
    class AnimalsTest
    {
        static void Main()
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog("Doggy", 22, Gend.Male));
            animals.Add(new Dog("Bitch", 23, Gend.Female));
            animals.Add(new Frog("Frogo", 3, Gend.Male));
            animals.Add(new Frog("Froda", 2, Gend.Female));
            animals.Add(new Kitten("Pussicat Doll", 2));
            animals.Add(new Tomcat("Cat in Boots", 2));
            animals.Add(new Kitten("Sweety", 1));
            animals.Add(new Kitten("Honey", 0));
            animals.Add(new Tomcat("Tommy boy", 0));


            var queryAnimals =
            from animal in animals
            group animal by animal.GetType().Name into animalTypeGroup
            select new
            {
                animalType = animalTypeGroup.Key,
                animalAvgAge = animalTypeGroup.Average(animal => animal.Age)
            };


            foreach (var data in queryAnimals)
            {
                Console.WriteLine("Animal type: {0}; Average age: {1:F2} years",
                    data.animalType, data.animalAvgAge);
            }
        }
    }
}