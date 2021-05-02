using System;
using System.Collections.Generic;
using System.Text;

namespace Test_NMLT
{
    class XL_MATRAN
    {
        //Bài 311 + 313: Viết hàm nhập xuất ma trận số nguyên
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
                    A[i, j] = int.Parse(Console.ReadLine());
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

        //Bài 315: Viết hàm tìm giá trị lớn nhất trong ma trận số thực
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
        
        //Bài 317: Viết hàm đếm số lượng số nguyên tố trong ma trận số nguyên
        public static int DemNguyenTo(int[,] A)
        {
            int Dem = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (XL_SONGUYEN.KiemTraNguyenTo(A[i, j]) == true)
                    {
                        Dem++;
                    }
                }
            }
            return Dem;
        }

        //Bài 327: Tính tổng các giá trị nằm trên biên của ma trận
        public static int TongBien(int[,] A)
        {
            int s = 0;
            for (int j = 0; j < A.GetLength(1); j++) // Tinh 2 dong bien
            {
                s = s + A[0, j];
                s = s + A[A.GetLength(0)-1, j]; // Dong cuoi 
            }
            for (int i = 1; i < A.GetLength(0)-1; i++) // Tinh 2 cot bien , nho bo dong dau tien
            {
                s = s + A[i,0];
                s = s + A[i, A.GetLength(1)-1]; // Cot cuoi
            }
            return s;
        }
    }
}
