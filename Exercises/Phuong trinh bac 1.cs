using System;

namespace Phuong_trinh_bac_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Xét phương trình ax + b = 0
                Nếu a = 0 và b = 0: phương trình có vô số nghiệm.
                Nếu a = 0 và b <> 0: phương trình vô nghiệm.
                Nếu a <> 0: phương trình có nghiệm duy nhất x = -b : a
            */
            Console.WriteLine("Nhap a: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap b: ");
            int b = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phuong trinh co vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");

                }
            }
            else
            {
                double x = 1.0 * -b / a;
                Console.WriteLine($"Phuong trinh co nghiem duy nhat x = -b/a = {x}"); 
            }
        }
    }
}
