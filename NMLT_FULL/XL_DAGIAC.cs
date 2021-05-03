using System;
using System.Collections.Generic;
using System.Text;

namespace Test_NMLT
{
    public struct DAGIAC
    {
        public DIEM[] dsDinh;
    }
    class XL_DAGIAC
    {
        public static DAGIAC NhapDaGiac()
        {
            DAGIAC dg;
            Console.WriteLine("Nhap so dinh cua da giac");
            int N = int.Parse(Console.ReadLine());
            dg.dsDinh = new DIEM[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Nhap dinh {i + 1}:");
                dg.dsDinh[i] = XL_DIEM.NhapDiem();
            }

            return dg;
        }
        public static double TinhChuVi(DAGIAC dg)
        {
            double chuVi = 0;
            int N = dg.dsDinh.Length;
            for (int i = 0; i < N-1; i++) //khong tinh dinh cuoi cuoi
            {
                chuVi = chuVi + XL_DIEM.TinhKhoangCach(dg.dsDinh[i], dg.dsDinh[i + 1]);
            }
            //Khoang cach giua dinh dau tien va dinh cuoi cung
            chuVi = chuVi + XL_DIEM.TinhKhoangCach(dg.dsDinh[0], dg.dsDinh[N - 1]);
            
            return chuVi;
        }
    }
}
