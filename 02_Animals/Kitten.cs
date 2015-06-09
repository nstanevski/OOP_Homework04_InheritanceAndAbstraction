using System;


namespace _02_Animals
{
    class Kitten:Cat
    {
        public Kitten(string name, int age)
            :base(name,age,Gend.Female)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Myau - myau");
        }
    }
}
