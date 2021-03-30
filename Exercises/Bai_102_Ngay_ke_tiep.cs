using System;

namespace Ngay_ke_tiep
{
    class Program
    {
        static void Main(string[] args)
        {
            int ngay,thang, nam;

            Console.WriteLine("Nhap ngay: ");
            ngay = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap thang: ");
            thang = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap nam: ");
            nam = int.Parse(Console.ReadLine());

            int soNgay = 0;

            if (thang >= 1 && thang <= 12)
            {
                switch (thang)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        soNgay = 31; break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        soNgay = 30; break;
                    case 2:
                        if ((nam % 400 == 0) || (nam % 4 == 0 && nam % 100 != 0))
                        {
                            soNgay = 29;
                        }
                        else
                        {
                            soNgay = 28;
                        }
                        break;
                }
                int ngayke, thangke, namke;
                ngayke = ngay + 1;
                thangke = thang;
                namke = nam;
                
                if (ngayke > soNgay)
                {
                    ngayke = 1;
                    thangke = thang +1;
                }
                if (thangke > 12)
                {
                    ngayke = 1;
                    thangke = 1;
                    namke = nam + 1;
                }
                
                Console.WriteLine($"Ngay ke tiep la ngay {ngayke} thang {thangke} nam {namke}");
            }
            else
            {
                Console.WriteLine("Nhap ngay/thang/nam khong hop le");
            }
        
        }
    }
}
