//Bài 20: Liệt kê tất cả các “ước số” của số nguyên dương n
// Optimie chay toi N - 2

using System;

namespace Bai_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int i = 1;
            Console.WriteLine("Nhap N: ");
            N = int.Parse(Console.ReadLine());
            while (i <= N - 2)
            {
                if (N % i == 0)
                    Console.WriteLine(i);
                i++;
            }
            Console.WriteLine(N);
        }
    }

}

