using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void login(string x, bool y)
        {
            if (y)
            {
                Console.WriteLine("{0}先生,歡迎光臨!", x);
            }
            else
            {
                Console.WriteLine("{0}小姐,歡迎光臨!", x);

            }

            

        }
        static void Main(string[] args)
        {
            string name = "王小華";
            login(name, true);
            Console.WriteLine();
            login("李美美", false);
            Console.Read();
        }
    }
}
