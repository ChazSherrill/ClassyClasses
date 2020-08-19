using System;

namespace My_Second_Csharp_Program
{
    class Program
    {
        class Person
        {
            int age;
            string name;
            public void SayHi()
            {
                Console.WriteLine("hi");
            }//The above is a class, with a method and some variables inside
        }
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.SayHi();//the . operator that is used to access and call the method of the object
        }//the new operator instantiates an object and returns a reference to its location
    }
}
