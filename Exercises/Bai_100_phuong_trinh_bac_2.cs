using System;

namespace Phuong_trinh_bac_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ax2+bx+c=0 (a≠0)
            Buoc 1: delta = b**2 - 4ac
            Buoc 2: So sanh delta voi 0:
                delta < 0 : phuong trinh vo nghiem
                delta = 0 : phuong trinh co nghiem kep x1 = x2 = -b/2a
                delta > 0 : phuong trinh co 2 nghiem phan biet
                    x1 = (-b + sqrt(delta)) / 2a
                    x1 = (-b - sqrt(delta)) / 2a
            */
            // Nhap gia tri

            int a, b, c;

            Console.WriteLine("Nhap a: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap b: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap c: ");
            c = int.Parse(Console.ReadLine());

            // Buoc 1
            double delta = -1.0 * (b * b) / (4 * a * c);

            // Buoc 2
            /* //Cach giai if-else 
            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else
            { 
                if (delta == 0)
                {
                    double x = -b / (2.0 * a); /// Bien ve so thuc
                    Console.WriteLine($"Phuong trinh co hai nghiem kep x1 = x2 = {x}");
                }
                else
                {
                    //double x1 = Math.Round((-b + Math.Sqrt(delta))/(2*a),4); 
                    //double x2 = Math.Round((-b - Math.Sqrt(delta)) / (2 * a), 4);
                    double x1 = ((-b / 2) - Math.Sqrt(delta)) / a;
                    double x2 = ((-b / 2) + Math.Sqrt(delta)) / a;

                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet:");
                    Console.WriteLine($"x1 = {x1}");
                    Console.WriteLine($"x2 = {x2}");

                */
            //Cach giai switch case
            switch (delta < 0)
            {
                case true:
                    Console.WriteLine("Chương trình vô nghiệm");
                    break;
                case false:
                    switch (delta == 0)
                    {
                        case true:
                            float x = (-b / 2) / a;
                            Console.WriteLine("Phương trình có nghiệm kép x1 = x2 = {0}", x);
                            break;
                        default:
                            double x1 = 0;
                            double x2 = 0;

                            x1 = ((-b / 2) - Math.Sqrt(delta)) / a;
                            x2 = ((-b / 2) + Math.Sqrt(delta)) / a;

                            Console.WriteLine("Phương trình có 2 nghiệm phân biệt: ");
                            Console.WriteLine("x1 = {0}", x1);
                            Console.WriteLine("x2 = {0}", x2);
                            break;
                    }
                    break;
            }
        }
    }
}