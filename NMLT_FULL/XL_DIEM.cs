using System;
using System.Collections.Generic;
using System.Text;

namespace Test_NMLT
{
    public struct DIEM //Dinh nghia data type diem
    {
        public int X;
        public int Y;
    }
    class XL_DIEM
    {
        public static DIEM NhapDiem()
        {
            DIEM a;
            Console.WriteLine("Nhap toa do x:");
            a.X = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap toa do y:");
            a.Y = int.Parse(Console.ReadLine());
            
            return a;
        }
        public static double TinhKhoangCach(DIEM a, DIEM b)
        {
            return Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
        }
        public static string XuatDiem(DIEM a)
        {
            return $"({a.X},{a.Y})";
        }
    }   
}

