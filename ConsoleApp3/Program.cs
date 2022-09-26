using System;
using System.Collections.Generic;
namespace ConsoleApp3
{


    class Family
    {
       public class Person
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
            public Person(int ageOf)
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
       public static List<Person> family = new List<Person>();




        public static void AddMember(ref Person member)
        {
            
            family.Add(member);

        }
        public static void GetOldestMember()
        {
            Person oldest = family[0];
            foreach (Person member in family)
            {
                if(member.Age > oldest.Age)
                {
                    oldest = member;
                }

            
            }
            Console.WriteLine($"The oldest is {oldest.Name} ({oldest.Age})");
        }
      

    }


    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Write amount of members");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Family.Person member = new Family.Person();  
                member=new Family.Person();
                Console.Write("new member`s name ");
                member.Name = Console.ReadLine();
                Console.Write("new member`s age ");
                member.Age = int.Parse(Console.ReadLine());
              
                Family.AddMember(ref member);
               // Console.WriteLine($"{member.Age} {member.Name}");
            }

          Family.GetOldestMember();



        }
    }
}
