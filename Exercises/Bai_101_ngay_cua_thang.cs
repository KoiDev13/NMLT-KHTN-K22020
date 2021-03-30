// Bài 101: Viết chương trình nhập tháng, năm. Hãy cho biết tháng đó có bao nhiêu ngày

using System;

namespace So_ngay_cua_thang
{
    class Program
    {
        static void Main(string[] args)
        {
            int thang, nam;

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
            }
            else
            {
                Console.WriteLine("Nhap thang/nam khong hop le");
            }
            Console.ReadLine();
        }
    }
}
