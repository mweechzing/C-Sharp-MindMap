using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        enum WeekDays : int
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Senday = 7,
        };


    static void Main(string[] args)
        {
            Console.WriteLine("WeekDays.WednesDay :{0}", (int)WeekDays.Wednesday);
            Console.WriteLine("WeekDays.Friday :{0}", (int)WeekDays.Friday);
            Console.Read();
        }
    }
}
