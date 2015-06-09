using System;

namespace _02_Animals
{
    class Tomcat:Cat
    {
        public Tomcat(string name, int age)
            :base(name, age, Gend.Male)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Mrrr...");
        }
    }
}
