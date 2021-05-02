using System;
using System.Collections.Generic;
using System.Text;

namespace Test_NMLT
{
    public struct PHANSO //Dinh nghia kieu du lieu moi 
    {
        public int TuSo;
        public int MauSo;
    }
    class XL_PHANSO
    {
        public static PHANSO NhapPhanSo()
        {
            PHANSO kq;
            Console.WriteLine("Nhap tu so: ");
            kq.TuSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau so: ");
            kq.MauSo = int.Parse(Console.ReadLine());

            return kq;
        }
        public static string XuatPhanSo(PHANSO a)
        {
            return $"{a.TuSo}/{a.MauSo}";
        }

        public static PHANSO TinhTong(PHANSO a, PHANSO b)
        {
            PHANSO kq;
            kq.TuSo = a.TuSo * b.MauSo + a.MauSo * b.TuSo;
            kq.MauSo = a.MauSo * b.MauSo;

            return kq;
        }
            
    }
}
