using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            i = int.Parse(Console.ReadLine());
            if (i>19 || i < 10)
            {
                Console.WriteLine("你的年齡是{0},不是青少年", i);
            }
            else
            {
                Console.WriteLine("你的年齡是{0},是青少年", i);
               
            }
            Console.Read();

        }
    }
}
