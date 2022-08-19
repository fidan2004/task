using System;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int total = 3;
            Person[] persons = new Person[total];

            for (int i = 0; i < total; i++)
            {
                persons[i] = new Person(Console.ReadLine());
            }

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(persons[i]);
            }
        }

        public class Person
        {
            
         public string name;

            public Person(string name)
            {
               this.name = name;
            }

            public override string ToString()
            {
                return "Hello! My name is " + name;
            }
        }
    }
}
   
