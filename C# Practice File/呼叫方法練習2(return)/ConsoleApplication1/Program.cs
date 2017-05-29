using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static string login(string x, bool y)
        {
            string str = "";
            if (y)
            {
                str = x + "先生,歡迎光臨!";
            }
            else
            {
                str = x + "小姐,歡迎光臨!";
            }

            return str;

        }
        static void Main(string[] args)
        {
            string name = "王小華";
            
            Console.WriteLine(login(name, true));
            Console.WriteLine();
            Console.WriteLine(login("李美美", false));
            Console.Read();
        }
    }
}
