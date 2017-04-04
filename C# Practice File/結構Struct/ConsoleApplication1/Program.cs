using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        struct Product
        {
            public int Price;
            public string Name, No; 

        }


        static void Main(string[] args)
        {
            Product game, cookie;
            game.No = "G01";
            game.Name = "Xbox One";
            game.Price = 10000;
            Console.Write("請輸入產品編號:");
            cookie.No = Console.ReadLine();
            Console.Write("請輸入產品名稱:");
            cookie.Name = Console.ReadLine();
            Console.Write("請輸入產品單價:");
            cookie.Price = int.Parse(Console.ReadLine());
            Console.Read();


        }
    }
}
