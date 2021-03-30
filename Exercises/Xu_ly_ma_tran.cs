using System;

namespace Xu_ly_ma_tran
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A;
            //Nhap ma tran
            int N, M;
            Console.WriteLine("Nhap so dong: ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so dong: ");
            M = int.Parse(Console.ReadLine());
            A = new int[N, M];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.WriteLine($"Nhap A[{i},{j}]:");
                    A[i, j] = int.Parse(Console.ReadLine());
                }    
            }
            // Tinh tong cac phan tu ma tran
            int S = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    S = S + A[i,j];
                }
            }
            // Xuat ma tran
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write($"{A[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
