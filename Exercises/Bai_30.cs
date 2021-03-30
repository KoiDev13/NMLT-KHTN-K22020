// Bài 30: Cho số nguyên dương n. Kiểm tra xem n có phải là số hoàn thiện hay không

using System;

namespace Bai_30
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,i,sum;
            sum = 0;
          
            Console.WriteLine("Nhap N: ");
            N = int.Parse(Console.ReadLine());
            Console.Write("Cac uoc so cua N: ");

            for (i = 1; i < N; i++)
            {
                if (N % i == 0)
                {
                    sum = sum + i;
                    Console.Write($"{i} ");
                }
            }
            Console.Write("\n Tong cua cac uoc so la {0}", sum);
            if (sum == N)
            {
                Console.Write("\nSo da cho la so hoan hao.");
            }
            else
            {
                Console.Write("\nSo da cho la khong phai so hoan hao.");
            }      
        }
    }

}
