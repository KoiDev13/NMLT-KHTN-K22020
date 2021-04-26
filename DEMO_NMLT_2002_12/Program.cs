using System;

namespace DEMO_NMLT_2002_12
{
    class Program
    {
        static int F(int x)
        {
            int kq;
            kq = x + 1;
            return kq;
        }
        static void T()
        {
            Console.WriteLine("ABC");
        }
        
        static void Main(string[] args)
        {
            int[] A = XL_MANG.NhapMang();
            int[] B = XL_MANG.NhapMang();
            //Tinh tong
            //int kq = XL_MANG.TimChanCuoiCung(B);
            //Xuat mang
            XL_MANG.Bai235(A, B);
            //Console.WriteLine(kq);
            /*
            int ngay, thang, nam;
            Console.WriteLine("Nhap ngay:");
            ngay = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thang:");
            thang = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nam:");
            nam = int.Parse(Console.ReadLine());

            int ngayke;
            int thangke;
            int namke;

            XL_Ngay.TimNgayKeTiep(ngay, thang, nam, out ngayke, out thangke, out namke);
            
            Console.WriteLine($"{ngayke}/{thangke}/{namke}");

            //Truyen tham tri => lay gia tri cua x0
            //Console.WriteLine(f1);
            //Console.WriteLine(a);

            /*
            for (int i = 2;i<=9;i++)
            {
                //in cuu chuong i
                for (int j=1;j<=10;j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }

                Console.WriteLine("------------------------");
            }

            /*
            int N;
            Console.WriteLine("Nhap N:");
            N = int.Parse(Console.ReadLine());
            int S = 0;
            for (int i = 1; i <= N / 2; i++)
            {
                if (N % i == 0)
                {
                    S = S + i;
                }
            }

            bool laHoanThien = (S == N);
            Console.WriteLine("Ket qua la " + laHoanThien);

            /*
            int N;
            Console.WriteLine("Nhap N:");
            N = int.Parse(Console.ReadLine());

            bool laNguyenTo = true;
            if (N <= 1)
            {
                laNguyenTo = false;
            }
            else
            {
                for (int i = 2;i <= N/2; i++)
                {
                    if (N % i == 0)
                    {
                        laNguyenTo = false;
                        break;//Vong lap se ket thuc ngay lap tuc
                    }
                }
            }
            if (laNguyenTo == true)
            {
                Console.WriteLine("Day la so nguyen to");
            }
            else
            {
                Console.WriteLine("Day KHONG PHAI la so nguyen to");
            }

            /*
            int N;
            Console.WriteLine("Nhap N:");
            N = int.Parse(Console.ReadLine());

            int i = 1;
            while (i <= N/2)
            {
                if (N % i == 0)
                {
                    Console.WriteLine(i);
                }
                i = i + 1;
            }
            Console.WriteLine(N);


            /*
            int N;
            Console.WriteLine("Nhap N:");
            N = int.Parse(Console.ReadLine());

            int S = 0;
            int GTi = 1;
            int i = 1;

            while (i <= N)
            {
                //Tinh GTi = i!
                GTi = GTi * i;
                S = S + GTi;
                i = i + 1;
            }
            Console.WriteLine($"Ket qua la {S}");

            /*
            int N;
            Console.WriteLine("Nhap N:");
            N = int.Parse(Console.ReadLine());

            int T = 1;
            int i = 1;
            while (i <= N)
            {
                T = T * i;
                i = i + 1;
            }
            Console.WriteLine($"Ket qua la {T}");
            /*
            int N;
            Console.WriteLine("Nhap N:");
            N = int.Parse(Console.ReadLine());

            int S = 0;
            int i = 1;
            while (i <= N)
            {
                S = S + i * i;
                i = i + 1;
            }

            Console.WriteLine($"Ket qua la {S}");
            /*
            int ngay, thang, nam;
            Console.WriteLine("Nhap ngay:");
            ngay = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thang:");
            thang = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nam:");
            nam = int.Parse(Console.ReadLine());

            int ngayTrongThang = 31;
            if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
            {
                ngayTrongThang = 30;
            }
            if (thang == 2)
            {
                if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
                {
                    ngayTrongThang = 29;
                }
                else
                {
                    ngayTrongThang = 28;
                }
            }

            int ngayke, thangke, namke;
            ngayke = ngay + 1;
            thangke = thang;
            namke = nam;

            if (ngayke > ngayTrongThang)
            {
                ngayke = 1;
                thangke = thangke + 1;
            }

            if (thangke > 12)
            {
                thangke = 1;
                namke++;
            }

            Console.WriteLine($"Ket qua la {ngayke}/{thangke}/{namke}");

            /*
            int a, b, c;

            Console.WriteLine("Nhap a:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap b:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap c:");
            c = int.Parse(Console.ReadLine());

            int delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else //delta >=0
            {
                if (delta == 0)
                {
                    double x = -b / (2.0 * a);
                    Console.WriteLine($"Nghiem kep x = {x}");
                }
                else //delta > 0
                {
                    double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"Nghiem x1 = {x1} va x2 ={x2}");
                }
            }

            /*
            int a;
            int b;

            Console.WriteLine("Nhap a:");
            string chuoi = Console.ReadLine();
            a = int.Parse(chuoi);

            Console.WriteLine("Nhap b:");
            b = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phuong trinh vo so nghiem");
                }
                else //b!=0
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            }
            else //a != 0
            {
                double x = -1.0 * b / a;
                Console.WriteLine($"Nghiem x = {x}");
            }
            */
        }
    }
}
