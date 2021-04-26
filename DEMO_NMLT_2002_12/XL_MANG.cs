using System;
using System.Collections.Generic;
using System.Text;

namespace DEMO_NMLT_2002_12
{
    class XL_MANG
    {
        public static int[] NhapMang()
        {
            int[] A;//KHAI bao A la mang chua nhieu phan tu, moi phan tu la mot INT
            //NHap mang
            Console.WriteLine("NHap so luong phan tu:");
            int N = int.Parse(Console.ReadLine());

            A = new int[N];//Xac dinh A chua N phan tu INT
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"NHap A[{i}]:");
                A[i] = int.Parse(Console.ReadLine());//Chi So bat dau tu 0
            }

            return A;
        }
        public static int TinhTong(int[] A)
        {
            int S = 0;
            for (int i = 0; i < A.Length; i++)//A.Length la so luong phan tu cua mang
            {
                S = S + A[i];
            }

            return S;
        }

        public static int TimMin(int[] A)
        {
            int min = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] < min)
                {
                    min = A[i];
                }
            }

            return min;
        }

        public static double TinhTBCDuong(int[] A)
        {
            int S = 0;
            int DemDuong = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    S = S + A[i];
                    DemDuong = DemDuong + 1;
                }
            }

            if (DemDuong > 0)
            {
                return 1.0 * S / DemDuong;
            }

            return 0;
        }

        public static double TinhTBCNguyenTo(int[] A)
        {
            int S = 0;
            int Dem = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (XL_SONGUYEN.KiemTraNguyenTo(A[i]))
                {
                    S = S + A[i];
                    Dem = Dem + 1;
                }
            }

            if (Dem > 0)
            {
                return 1.0 * S / Dem;
            }

            return 0;
        }

        public static void XuatMang(int[] A)
        {
            for (int i = 0; i < A.Length; i++)//A.Length la so luong phan tu cua mang
            {
                Console.WriteLine(A[i]);
            }
        }

        public static int TimDuongDauTien(int[] A)
        {
            for (int i=0; i<A.Length; i++)
            {
                if (A[i] > 0)
                {
                    return A[i];
                }
            }
            //Khong ton tai phan tu duong
            return -1;
        }

        public static int TimChanCuoiCung(int[] A)
        {
            for (int i = A.Length - 1; i>=0;  i--)
            {
                if (A[i] % 2 == 0)
                {
                    return A[i];
                }
            }
            //Khong ton tai phan tu duong
            return -1;
        }

        public static void ThongKePhanTu(int[] A)
        {
            for (int i=0;i<A.Length;i++)
            {
                bool DaDem = false;
                for (int j=0;j<i;j++)
                {
                    if (A[j] == A[i])//A[i] da duoc dem truoc do
                    {
                        DaDem = true;
                        break;
                    }
                }
                //Dem A[i] xuat hien bao nhieu lan IF chua dem A[i] truoc do
                if (DaDem == false)
                {
                    int Dem = 1;
                    for (int j = i + 1; j < A.Length; j++)
                    {
                        if (A[j] == A[i])
                        {
                            Dem++;
                        }
                    }
                    //Xuat ket qua cua A[i]
                    Console.WriteLine($"{A[i]} xuat hien {Dem} lan");
                }
            }
        }

        public static int TimViTriXuatHien(int[] A, int v)
        {
            for (int i=0;i<A.Length;i++)
            {
                if (A[i] == v)
                {
                    return i;
                }
            }
            return -1;//v Khong xuat hien trong A
        }
        public static void Bai235(int[] A, int[] B)
        {
            for (int i=0;i<A.Length;i++)
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
