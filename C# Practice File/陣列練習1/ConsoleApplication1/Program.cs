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
            string[] name = new string[] { "魯夫", "橋八", "三明治" };
            int[] money = new int[] { 50, 40, 30 };
            Console.WriteLine("==草帽海賊團成員==\n");
            Console.WriteLine("姓名\t懸賞金額");
            Console.WriteLine("================");
            for (int i=0;i <= name.GetUpperBound(0); i++)
            {
                Console.WriteLine("{0}\t{1}", name[i],money[i]);
            }







            Console.Read();


        }
    }
}
