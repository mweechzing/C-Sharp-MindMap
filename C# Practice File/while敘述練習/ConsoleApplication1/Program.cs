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
            int Ans, ins = 0, chs = 0;
            Console.Write("請輸入獄求因數的數直(1-50)");
            Ans = int.Parse(Console.ReadLine());
            if (Ans > 0&&Ans < 51)
             {
                Console.WriteLine();
                Console.WriteLine("==求 1 到 100 能被 {0} 整除的因數==\n", Ans);
                while (chs < 100)
                {
                    ins += 1;
                    chs = Ans * ins;
                    if (chs > 100)
                    {
                        break;
                    }
                    Console.Write("\t{0},", chs);
                    while (ins%5 == 0)
                    {
                        Console.WriteLine("\n");
                        break;
                    }

                }


            }
            else
            {
                Console.WriteLine("\n==資料輸入錯誤==");
                Console.Read();
            }
            Console.Write("\n\n===由1到100共有{0}個整數可以被{1}整除!", ins, Ans);
            Console.Read();

        }
    }
}
