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
            double sum = 0;
            Console.WriteLine("請輸入人數");
            int people = int.Parse(Console.ReadLine());
            double[] height = new double[people];
            for(int i=0; i <=height.GetUpperBound(0);i++)
            {
                Console.WriteLine("請輸入第{0}位身高", i + 1);
                height[i] = double.Parse(Console.ReadLine());
            }
            foreach (double number in height)
            {
                sum += number;
            }
            Console.WriteLine("==={0}位平均身高:{1}", people, sum / people);
            Console.Read();


        }
    }
}
