using System;

namespace _02_Animals
{
    class Dog:Animal
    {
        public Dog(string name, int age, Gend gender)
            :base(name, age, gender)

        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Bau-bau");
        }

    }
}
