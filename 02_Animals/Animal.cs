using System;


namespace _02_Animals
{
    public enum Gend { Female, Male};

    public abstract class Animal:ISoundProducible
    {
        private string name;
        private int age;
        private Gend gender;

        public Animal(string name, int age, Gend gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException(
                        "Name cannot be null, empty or whitespace only"
                        );
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0 || value > 30)
                    throw new ArgumentOutOfRangeException("Age is a number in range [1..30]");
                this.age = value;

            }
        }

        public Gend Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                if ((int)value < 0 || (int)value > 1)
                    throw new ArgumentOutOfRangeException(
                        "Gender can be either 0 or 1 (female/male)");
                this.gender = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Name, Age, Gender);
        }



        public abstract void ProduceSound();
    }
}
