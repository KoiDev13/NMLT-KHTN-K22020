// Bài 11: Tính S(n) = 1 + 1.2 + 1.2.3 + … +1.2.3….N
/*
S(1) = 1!
S(2) = 1! + 2!
S(3) = 1! + 2! + 3!
 */

using System;

namespace Bai_11
{
    class Program
    {
        static int TinhGiaiThua(int n)
        {
            int kq = 1;
            for (int i = 2; i <= n; i++)
            {
                kq = kq * i;
            }
            return kq;

        }

        static int TinhTong(int n)
        {
            int kq = 0;
            for (int i = 1; i <= n; i++)
            {
                kq = kq + TinhGiaiThua(i);
            }
            return kq;
        }
        static void Main(string[] args)
        {
            int N, a;
            Console.WriteLine("Nhap N: ");
            N = int.Parse(Console.ReadLine());
            a = TinhTong(N);
            Console.WriteLine($"Ket qua cua s la {a}");

            /* --- Cach cu
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
                i = i + 1;
            }
            Console.WriteLine($"Ket qua cua s la {s}");
            */
        }
    }
}