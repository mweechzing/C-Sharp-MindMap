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
            int textRate = 0;
            Console.WriteLine("請輸入全年綜合所得淨額:");
            double netIncome = double.Parse(Console.ReadLine());
            if (netIncome > 0) {
                textRate = netIncome <= 50 ? 5 : (netIncome <= 113 ? 12 : (netIncome <= 226 ? 20 : (netIncome <= 423 ? 30 : 40)));
                Console.WriteLine("{0}萬元 的 所得稅率為{1}", netIncome, textRate);
            }else
            {
                Console.WriteLine("所得為負,不用繳稅");
            }
            Console.Read();










        }
    }
}
