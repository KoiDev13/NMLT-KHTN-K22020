//Bài 21: Tính tổng tất cả các “ ước số” của số nguyên dương n

using System;

namespace Bai_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap 1 so bat ky can tinh TONG cac UOC SO : ");
            int n = int.Parse(Console.ReadLine());
            int k = 0;
            Console.Write("Danh sach cac UOC SO : ");
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("{0}   ", i);
                    k = k + i;
                }
            }
            Console.WriteLine();
            Console.WriteLine(" --> Tong cac UOC SO : {0}", k);
        }
    }
}
