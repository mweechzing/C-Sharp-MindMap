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
            string PasWord = "";
            for (int i = 1;i <=3 ; i++)
            {
                Console.Write("請輸入密碼:");
                PasWord = Console.ReadLine();
                if (PasWord == "ymca")
                {

                    break;
                }
                else
                {
                    Console.WriteLine("登入失敗,密碼錯誤{0}次", i);
                }
            }

            if (PasWord == "ymca")
            {
                Console.WriteLine("登入成功!");
            }
            else
            {
                Console.WriteLine("非法登入");
            }
            Console.Read();


        }
    }
}
