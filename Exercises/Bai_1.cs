// Bài 1: Tính S(n) = 1 + 2 + 3 + … + n

using System;

namespace Bai_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Nhap N: ");
            N = int.Parse(Console.ReadLine());

            int s = 0;
            int i = 1;
            while (i < N)
            {
                s = s + i;
                i++;
            }
            Console.WriteLine($"Ket qua cua s la {s}");
        }
    }

}
