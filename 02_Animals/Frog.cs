using System;

namespace _02_Animals
{
    class Frog:Animal
    {
        public Frog(string name, int age, Gend gender)
            :base(name, age, gender)
        {

        }
        public override void ProduceSound()
        {
            Console.WriteLine("Quak-quak");
        }
    }
}
