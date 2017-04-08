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
            int count = 1,sum = 0;
            string Ans = "";
            Console.WriteLine("成是與研成績計算");
            do
            {
                do
                {

                    Console.Write("請輸入第{0}位同學成績", count);
                    int score = int.Parse(Console.ReadLine());
                    sum += score;
                    count += 1;
                    Console.WriteLine("\n是否繼續? (Y/N)?");
                    Ans = Console.ReadLine();

                } while (Ans == "Y" || Ans == "y");
                if (Ans == "N" || Ans == "n")
                {
                    Console.WriteLine("共輸入{0}位同學成績,班上平均成績{1}", count - 1, sum / (count - 1));
                }
                else
                {
                    Console.WriteLine("資料輸入錯誤");

                }

            } while (Ans != "N" && Ans != "n"&&Ans != "Y"&&Ans !="y");



            Console.Read(); 

        }
    }
}
