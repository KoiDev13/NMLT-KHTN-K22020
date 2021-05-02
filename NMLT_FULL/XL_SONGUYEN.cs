using System;
using System.Collections.Generic;
using System.Text;

namespace DEMO_NMLT_2002_12
{
    class XL_SONGUYEN
    {
        public static void HoanVi(ref int x, int y)
        {
            int t = x;
            x = y;
            y = t;
        }
        public static int TinhGiaiThua(int n)
        {
            int kq = 1;
            for (int i = 2; i <= n; i++)
            {
                kq = kq * i;
            }
            return kq;
        }
        public static bool KiemTraNguyenTo(int n)
        {
            if (n <= 1)
            {
                return false;
            }

            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        public static void LietKeNguyenTo(int n)
        {
            for (int i = 2; i <= n; i++)
            {
                if (KiemTraNguyenTo(i) == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static int TinhS11(int n)
        {
            int kq = 0;
            for (int i = 1; i <= n; i++)
            {
                kq = kq + TinhGiaiThua(i);
            }
            return kq;
        }
        public static int TimMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }

            return b;
        }
    }
}
