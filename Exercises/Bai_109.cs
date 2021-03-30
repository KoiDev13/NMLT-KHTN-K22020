//Bài 109: Viết chương trình in bảng cửu chương ra màn hình

using System;

namespace Bai_109
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,i;
          
            Console.WriteLine("Nhap N: ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine($"Bang cuu chuong {N}");

            for (i = 1; i <= 10; i++)
            {
              
                Console.WriteLine($"{i} x {N} = {i*N}");
            }
        }
    }

}
