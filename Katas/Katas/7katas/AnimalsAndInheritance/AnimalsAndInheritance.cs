using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Katas._7katas.AnimalsAndInheritance
{
    public class AnimalsAndInheritance
    {
        public class Animal
        {
            public int Age;
            public int Legs;
            public string Name;
            public string Species;
            public string Status;

            public Animal(string name, int age, int legs, string species, string status)
            {
                this.Name = name;
                this.Age = age;
                this.Legs = legs;
                this.Species = species;
                this.Status = status;
            }

            

            public virtual string Introduce()
            {
                return $"Hello, my name is {this.Name} and I am {this.Age} years old.";
            }
        }
        public class Shark : Animal
        {
            public Shark(string name, int age, string status) : base(name,age,4,"shark",status)
            {
            }
        }

        public class Cat : Animal
        {
            public Cat(string name, int age, string status) : base(name, age, 4, "cat", status)
            {
            }
            public override string Introduce()
            {
                return $"Hello, my name is {this.Name} and I am {this.Age} years old.  Meow meow!";

            }
        }

        public class Dog : Animal
        {
            public string Master;
            public Dog(string name, int age, string status, string master) : base(name, age, 4, "dog", status)
            {
                this.Master = master;
            }
            public string greetMaster()
            {
                return $"Hello {this.Master}";
            }
        }



    }
}
