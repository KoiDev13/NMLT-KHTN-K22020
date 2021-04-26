using System;
using System.Collections.Generic;
using System.Text;

namespace DEMO_NMLT_2002_12
{
    class XL_Ngay
    {
        public static int TimSoNgayTrongThang(int thang, int nam)
        {
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

            return ngayTrongThang;
        }

        public static void TimNgayKeTiep(int ngay, int thang, int nam, out int ngayke, out int thangke, out int namke)
        {
            int ngayTrongThang = TimSoNgayTrongThang(thang, nam);

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
        }
    }
}
