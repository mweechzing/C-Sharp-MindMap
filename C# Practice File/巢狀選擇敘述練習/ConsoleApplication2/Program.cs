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
            int i, j, k, l = 0;
            Console.WriteLine("1.請輸入第一個數值:");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("1.請輸入第二個數值:");
            j = int.Parse(Console.ReadLine());
            Console.WriteLine("1.請輸入第三個數值:");
            k = int.Parse(Console.ReadLine());

            if (i > j)
            {
                if (i > k)
                {
                    l = i;
                }else
                {
                    l = k;
                }
            }
            else
            {
                if (j > k)
                {
                    l = j;
                }
                else
                {
                    l = k;
                }
            }
            Console.WriteLine("{0} ,{1} ,{2}三數中最大值為{3}",i,j,k,l);
            Console.Read();



        }
    }
}
