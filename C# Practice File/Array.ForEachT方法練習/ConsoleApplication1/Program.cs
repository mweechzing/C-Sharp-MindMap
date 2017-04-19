using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        const double PI = 3.14;
        static void Main(string[] args)
        {
            int[] arry = new int[] { 2, 4, 6, 8 };
            Action<int> maAction = new Action<int>(ShowArea);
            Array.ForEach(arry, maAction);
            Console.Read();
        }
        private static void ShowArea(int r)
        {
            Console.WriteLine("半徑:{0}的圓面積:{1}",r,r*r*PI);
        }



    }
}
