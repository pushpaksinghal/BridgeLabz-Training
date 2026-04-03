using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_constructor_accessmodifiers.level_1
{
    internal class Person
    {
        // created the atributes
        string name;
        int age;

        //default con
        public Person()
        {
            this.name = "jhon doe";
            this.age = 25;
        }
        //parameter con
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        //copy con
        public Person(Person Previous)
        {
            this.name = Previous.name;
            this.age = Previous.age;
        }
        // display method
        public void Display()
        {
            Console.WriteLine("the name is " + name + " and the age is " + age);
        }
    }

    class Display()
    {
        static void Main(string[] args)
        {
            // calling the class in main
            Person p1 = new Person();
            p1.Display();

            Person p2 = new Person("pushpak singhal", 21);
            p2.Display();

            Person p3 = new Person(p2);
            p3.Display();
        }
    }
}
