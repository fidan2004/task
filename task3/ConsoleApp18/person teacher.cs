using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18
{
   
    public class Person
    {
        public int age;

        public void Greet()
        {
            Console.WriteLine("Hello");
        }

        public void SetAge(int n)
        {
            age = n;
        }
    }

    public class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studying");
        }

        public void ShowAge()
        {
            Console.WriteLine("My age is {0} years old", age);
        }
    }

    public class Teacher : Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
    }
}
