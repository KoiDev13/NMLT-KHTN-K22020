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
            for (int i = 0; i < A.GetLength(0); i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j]);
                }
            }
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
                s = s + A[A.GetLength(0) - 1, j]; // Dong cuoi 
            }
            for (int i = 1; i < A.GetLength(0) - 1; i++) // Tinh 2 cot bien , nho bo dong dau tien
            {
                s = s + A[i, 0];
                s = s + A[i, A.GetLength(1) - 1]; // Cot cuoi
            }
            return s;
        }

        //Bài 322: Tính tổng các giá trị trên 1 dòng trong ma trận các số thực
        public static int Tong1Dong(int[,] A, int k)
        {
            Console.WriteLine("Nhap dong can tinh tong");
            k = int.Parse(Console.ReadLine());
            int s = 0;
            for (int j = 0; j < A.GetLength(1) ; j++)
            {
                s = s + A[k, j];
            }
            Console.WriteLine($"Tong cua dong {k} trong ma tran la {s}");
            return s;
        }
        //Bài 323: Tính tích các giá trị dương trên 1 cột trong ma trận các số thực
        public static int TongDuong1Cot(int[,] A)
        {
            int k;
            Console.WriteLine("Nhap cot can tinh tong");
            k = int.Parse(Console.ReadLine());
            int s = 0;
            for (int i = 0; i < A.GetLength(0) ; i++)
            {
                if (A[i, k] > 0)
                {
                    s = s + A[i, k];
                }
            }
            return s;
        }

        //Bài 351: Kiểm tra ma trận có toàn dương hay không
        public static bool KiemTraToanDuong(int[,] A)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] < 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        //Bài 352: Kiểm tra một hàng ma trận có tăng dần hay không
        public static bool KiemTraDongTang(int[,] A, int k)
        {
            for (int j = 0; j < A.GetLength(1) - 1; j++)
            {
                if (A[k, j]  > A[k, j+1])
                {
                    return false;
                }
            }
            return true;
        }

        //Bài 354: Kiểm tra các giá trị trong ma trận có giảm dần theo dòng và cột hay không
        public static bool KiemTraGiamDan(int[,] A)
        {
            int x = A[0, 0];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > x)
                    {
                        return false;
                    }
                    x = A[i, j];
                }
            }
            return true;
        }

        //Bài 381: Tìm giá trị xuất hiện nhiều nhất
        public static int TimPhanTuXuatHienNhieuNhat(int[,] A)
        {
            int kq = A[0, 0];
            int demMax = DemSoLanXuatHien(A, kq);
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (DemSoLanXuatHien(A, A[i,j]) > demMax)
                    {
                        demMax = DemSoLanXuatHien(A, A[i, j]);
                        kq = A[i, j];
                    }
                }
            }
            return kq;
        }

        public static int DemSoLanXuatHien(int[,] A,int x)
        {
            int dem = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] == x)
                    {
                        dem++;
                    }
                }
            }
            return dem;
        }
    }
}
