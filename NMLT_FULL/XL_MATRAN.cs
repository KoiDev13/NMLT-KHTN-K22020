using System;
using System.Collections.Generic;
using System.Text;

namespace Test_NMLT
{
    class XL_MATRAN
    {
        public static int[,] NhapMaTran()
        {
            int[,] A;
            int N, M;
            Console.WriteLine("Nhap so dong cua ma tran: ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so cot cua ma tran: ");
            M = int.Parse(Console.ReadLine());
            A = new int[N, M];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write($"A[{i},{j}] = ");
                    A[i,j] = int.Parse(Console.ReadLine());
                }
            }
            return A;
        }
        public static void XuatMaTran(int[,] A)
        {
            Console.WriteLine("Ma tran vua nhap la:");
            Console.Write("[");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j] + ",");
                }
            }
            Console.WriteLine("]");
        }
        public static int TinhTong(int[,] A)
        {
            int S = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    S = S + A[i, j];
                }
            }
            return S;
        }
        public static int TimMax(int[,] A)
        {
            int Max = A[0, 0];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > Max)
                    {
                        Max = A[i, j];
                    }
                }
            }
            return Max;
        }
        
    }
}
