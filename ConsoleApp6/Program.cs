using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
 
        class Employee
        {
            string name;
            double salary;
            string position;
            string department;
            string email ="n/d";
            int age = -1;


            public static List<Employee> employees = new List<Employee>();


            public static void Create(string[] emp)
            {
                 Employee empl = new Employee();

                empl.name = emp[0];
                empl.salary = Math.Round((Convert.ToDouble(emp[1])),2);
                empl.position = emp[2];
                empl.department = emp[3];

                if (emp.Length == 6)
                {
                    empl.email = emp[4];
                    empl.age = int.Parse(emp[5]);
                }
            else 
            if(emp.Length == 5)
            {
                try
                {
                    empl.age = int.Parse(emp[4]);
                }
                catch 
                { 
                empl.email=emp[4];
                }


            }


            employees.Add(empl);

        }


        public class Department
        {
            public  string name = null ;
      
            public  List <double> salarys = new List <double>();
            public  double averagesalary()
            {
                double avg=0;
                foreach(var sal in salarys)
                {
                    avg += sal;
                }
                avg=avg/salarys.Count;
                return avg;

            }
           public double avg;




        }
 
               public static List<Department> departments = new List<Department>();
   
        
        
        
        public static void funk()
        {
            Department dep = new Department();
            
            dep.name = employees[0].department;
            departments.Add(dep);
            for (int i = 0; i < employees.Count; i++)
            {
                for (int j = 0; j < departments.Count; j++)
                {
                    if (employees[i].department != departments[j].name)
                    {
                        Department emp = new Department();
                        emp.name = employees[i].department;
                        emp.salarys.Add(employees[i].salary);
                        departments.Add(emp);

                    }
                    else
                    {
                        departments[j].salarys.Add(employees[i].salary);
                    }
                }


            }

            for (int j = 0; j < departments.Count; j++)
            {
                departments[j].avg = departments[j].averagesalary();
            }

            double avg = departments[0].avg;
            string name = departments[0].name;
            for (int j = 0; j < departments.Count; j++)
            {
                if (departments[j].avg > avg)
                {
                    avg = departments[j].avg ;
                    name = departments[j].name;
                }
            }


            for (int i = 0; i < employees.Count-1; i++)
            {
                if(employees[i].salary< employees[i + 1].salary)
                {
                    Employee employee = employees[i];
                    employees[i] = employees[i + 1];
                    employees[i + 1] = employee;
                }
            }
            Console.WriteLine($"Highest Average Salary: {name}");
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].department == name)
                {
                    Console.WriteLine($"{employees[i].name} {employees[i].salary} {employees[i].email} {employees[i].age}");
                }

            }







        }











    }
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("Write count of employees");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                Console.WriteLine("write employee");
                string first;

                first = Console.ReadLine();

                char[] separators = new char[] { ' ' };

                string[] subs = first.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Employee.Create(subs);
            }

            Employee.funk();


        }
    }
}
