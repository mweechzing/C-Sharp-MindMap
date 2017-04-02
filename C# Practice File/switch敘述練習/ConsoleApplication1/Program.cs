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
            Console.WriteLine("題目:");
            Console.WriteLine("Visual Studio可以開發哪種應用程式");
            Console.WriteLine("1.視窗程式 2.Web程式 3.裝置應用程式 4.以上皆是");
            Console.Write("請作答:");
            string ans = Console.ReadLine();
            switch (ans)
            {
                case "1":
                case "2":
                case "3":
                    Console.WriteLine("答錯了,正確答案是4");
                    break;
                case "4":
                    Console.WriteLine("答對了");
                    break;
                default:
                    Console.WriteLine("沒有這個選項");
                    break;
            }
            
            Console.Read();
        }
    }
}
