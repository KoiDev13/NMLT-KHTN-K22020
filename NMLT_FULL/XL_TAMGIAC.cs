using System;
using System.Collections.Generic;
using System.Text;

namespace Test_NMLT
{
    public struct TAMGIAC
    {
        public DIEM A;
        public DIEM B;
        public DIEM C;
    }
    class XL_TAMGIAC
    {
        public static TAMGIAC NhapTamGiac()
        {
            TAMGIAC tg;
            Console.WriteLine("Nhap dinh A:");
            tg.A = XL_DIEM.NhapDiem();
            Console.WriteLine("Nhap dinh B:");
            tg.B  = XL_DIEM.NhapDiem();
            Console.WriteLine("Nhap dinh C:");
            tg.C  = XL_DIEM.NhapDiem();

            return tg;
        }
        public static double TinhChuVi(TAMGIAC tg)
        {
            double a, b, c;
            a = XL_DIEM.TinhKhoangCach(tg.A, tg.B);
            b = XL_DIEM.TinhKhoangCach(tg.B, tg.C);
            c = XL_DIEM.TinhKhoangCach(tg.C, tg.A);

            return a + b + c;
        }

    }
}
