using System;
using System.Collections.Generic;
using System.Text;

namespace Test_NMLT
{
    class XL_MANG
    {
        public static int[] NhapMang()
        {
            Console.WriteLine("Nhap so luong phan tu cua mang: ");
            int N = int.Parse(Console.ReadLine());
            int[] A;
            A = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write($"A[{i}] = ");
                A[i] = int.Parse(Console.ReadLine());
            }
            return A;
        }
        public static void XuatMang(int[] A)
        {
            Console.WriteLine("Mang vua nhap la:");
            Console.Write("[");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + ",");
            }
            Console.WriteLine("]");
        }
        public static int TinhTong(int[] A)
        {
            int S = 0;
            for (int i = 0; i < A.Length; i++)
            {
                S = S + A[i];   
            }
            return S;
        }
        public static int TimMin(int[] A)
        {
            int min = A[0];
            for (int i = 0; i < A.Length; i++)
            {
                if(A[i] < min)
                {
                    min = A[i];
                }
            }
            return min;
        }
        public static int TimViTriXuatHien (int[] A, int v)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == v)
                {
                    return i;
                }    
            }
            return -1;
        }
        public static int TimSoDuongDauTien(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    return A[i];
                }
            }
            return -1;
        }
        public static int TimSoChanCuoiCung(int[] A)
        {
            for (int i = A.Length - 1; i >= 0; i--)
            {
                if (A[i] % 2 == 0)
                {
                    return A[i];
                }
            }
            return -1;
        }
        public static void ThongKePhanTu(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                bool DaDem = false;
                for (int j = 0; j<i;  j++)
                {
                    if (A[i] == A[j])
                    {
                        DaDem = true;
                        break;
                    }        
                }
                if (DaDem == false)
                {
                    int Dem = 1;
                    for (int j = i + 1; j < A.Length; j++) //Để chỉnh lại số thứ tự đếm vì trong mảng bắt đầu từ 0
                    {
                        if (A[j] == A[i])
                        {
                            Dem++;
                        }
                    }
                    Console.WriteLine($"{A[i]} xuat hien {Dem} lan");
                }

            }
            
            
        }
        public static void TimAtrongB(int[] A, int[] B)
        {
            for (int i = 0; i < A.Length; i++)
            {
                //Kiem tra A[i] co xuat hien trong B khong
                if (TimViTriXuatHien(B, A[i]) == -1)//khong xuat hien trong B
                {
                    Console.WriteLine(A[i]);
                }
            }

            for (int i = 0; i < B.Length; i++)
            {
                //Kiem tra B[i] co xuat hien trong A khong
                if (TimViTriXuatHien(A, B[i]) == -1)//khong xuat hien trong A
                {
                    Console.WriteLine(B[i]);
                }
            }
        }
    }
}
