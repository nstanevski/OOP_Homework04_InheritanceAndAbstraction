using System;

namespace _02_Animals
{
    abstract class Cat:Animal
    {
        public Cat(string name, int age, Gend gender)
            :base(name,age, gender)
        {

        }

        public override abstract void ProduceSound();
    }
}
