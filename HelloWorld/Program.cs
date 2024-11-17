using System;

namespace HelloWorld
{
    public class Person
    {
        public string Name;
        public Person(string name)
        {
        this.Name = name;

            Console.WriteLine("Hello My name is {0}", name);
        }
        //public void Introduce(string to)
        //{
        //    Console.WriteLine("Hi {0}, I am {1}", to, Name);
        //}


        //public static Person Parse(string str)
        //{
        //    var person = new Person();
        //    person.Name = str;

        //    return person;
        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //var number = 3;
            //var float_value = 3.5f;
            //var character = 'a';
            //var string_value = "This is a string";
            //Console.WriteLine(number);
            //Console.WriteLine(float_value);
            //Console.WriteLine(character);
            //Console.WriteLine(string_value);
            //const float Pi = 3.142f;
            //Console.WriteLine(Pi);
            //person.Introduce("Azlan");

            var person = new Person("John");


        }
    }
}
