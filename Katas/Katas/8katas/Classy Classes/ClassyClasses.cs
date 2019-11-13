using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Katas._8katas.Classy_Classes
{
    public static class ClassyClasses
    {
        public static void Start()
        {

        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name,int age)
            {
                Name = name;
                Age = age;

            }

            public string Info
            {

                get { return $"johns age is {this.Age}"; }
            }

        }
    }
}
