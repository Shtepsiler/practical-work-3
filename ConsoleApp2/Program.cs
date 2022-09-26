using System;

namespace ConsoleApp1
{
    class Person
    {
        private string name = "Pesho";
        private int age = 20;

        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }
        public int Age
        // property
        {
            get { return age; }   // get method
            set { age = value; }  // set method
        }

        public Person()
        {
            name = "No name";
            age = 1;
        }
        public Person( int ageOf)
        {
            name = "No name";
            age = ageOf;
        }




        public Person(string nameOf, int ageOf)
        {
            name = nameOf;
            age = ageOf;
        }


    }


    internal class Program
    {
        static void Main()
        {
            Person Pesho = new Person();


            Person Gosho = new Person(18);


            Person Stamat = new Person("Stamat", 43);



            Console.Write($"{Pesho.Name} is {Pesho.Age}\n");
            Console.Write($"{Gosho.Name} is {Gosho.Age}\n");
            Console.Write($"{Stamat.Name} is {Stamat.Age}\n");



        }
    }
}
