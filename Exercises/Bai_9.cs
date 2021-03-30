//Bài 9: Tính T(n) = 1 x 2 x 3…x N

using System;

namespace Bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Nhap N: ");
            N = int.Parse(Console.ReadLine());

            int s = 1;
            int i = 1;
            while (i <= N)
            {
                s = s * i;
                i = i + 1;
            }
            Console.WriteLine($"Ket qua cua s la {s}");
        }
    }

}
