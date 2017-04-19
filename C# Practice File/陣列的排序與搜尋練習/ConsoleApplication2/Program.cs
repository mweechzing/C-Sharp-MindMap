using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] RoleName = new string[] {"敲八","騙人不","箱橘子" };
            int[] Money = new int[3];
            Money[0] = 50;
            Money[1] = 200;
            Money[2] = 230;
            Console.WriteLine("姓名\t懸賞金額\n==============\n");
            Array.Sort(Money, RoleName);
            for(int i = 0; i <= RoleName.GetUpperBound(0); i++)
            {
                Console.WriteLine("{0}\t{1}", RoleName[i], Money[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("姓名\t懸賞金額\n==============\n");
            Array.Reverse(RoleName);
            Array.Reverse(Money);
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("{0}\t{1}", RoleName[i], Money[i]);
            }




            Console.Read();





        }
    }
}
