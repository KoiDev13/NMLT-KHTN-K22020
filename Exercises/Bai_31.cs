//Bài 31: Cho số nguyên dương n. Kiểm tra xem n có phải là số nguyên tố hay không

using System;

namespace Bai_31
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int i ;
            Console.WriteLine("Nhap N: ");
            N = int.Parse(Console.ReadLine());

            bool lasoNguyento = true;

            if (N <= 1)
            {
                Console.WriteLine("Day khong phai la so nguyen to");
            }
            else
            {
                for (i = 2; i<=N-1; i++)
                { if (N % i==0)
                    {
                        lasoNguyento = false;
                        break;
                    }
                }
            }
            if (lasoNguyento == true)
            {
                Console.WriteLine("Day la so nguyen to");
            }
            else
            {
                Console.WriteLine("Day khong phai la so nguyen to");
            }


        }
    }

}
