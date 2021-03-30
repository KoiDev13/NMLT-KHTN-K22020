//Bài 1: Tính S(n) = 1 + 2 + 3 + … + n

using System;

namespace Bai_11
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
            int u = 1;
            int t = 1;

            while (i <= N)
            {
                
                while (t <= i)
                {
                    u = u * t; 
                    t = t + 1; 
                }
                s = s + u;
                i = i+1;
            }
            Console.WriteLine($"Ket qua cua s la {s}");
        }
    }

}
