using System;

namespace ConsoleApp5
{

    class DateModifier
    {
        class data
        {
            public int year;
            public int month;
            public int day;
        }


 
        static void writedata(out int year,out int month,out int day)
        {
            Console.WriteLine("write data");
            string data;

            data = Console.ReadLine();

            char[] separators = new char[] { ' ', ',', '.' };

            string[] subs = data.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[3]; int i = 0;
            foreach (var sub in subs)
            {
                numbers[i] = int.Parse(sub);
                i++;
            }
             year = numbers[0];
             month = numbers[1];
             day = numbers[2];

        }
           static data first = new data();
           static data second = new data();
        public static void Writedatas()
        {


            writedata(out first.year, out first.month, out first.day);
            writedata(out second.year, out second.month, out second.day);

        }


        public static int DiffInTheDays()
        {

           

            int Byears = Math.Abs(first.year-second.year);
            int Bmonths = Math.Abs(second.month-first.month);
            int Bdays = Math.Abs(second.day - first.day);

                int diff = Bdays + Bmonths*30 + Byears*256;




            return diff;
        }

    }




    internal class Program
    {
        static void Main(string[] args)
        {
            DateModifier.Writedatas();

            Console.WriteLine($"difference is {DateModifier.DiffInTheDays()}");
        }
    }
}
