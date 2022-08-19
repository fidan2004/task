using System;

namespace ConsoleApp18
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            Person myPerson = new Person();
            myPerson.Greet();

            Student myStudent = new Student();
            myStudent.SetAge(21);
            myStudent.Greet();
            myStudent.ShowAge();
            myStudent.Study();

            Teacher myTeacher = new Teacher();
            myTeacher.Greet();
            myTeacher.Explain();
        }
    }
}
        
        

         

