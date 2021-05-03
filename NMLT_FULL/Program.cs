using System;

namespace NMLT_FULL
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello_world");

            /*==================== XL_TAMGIAC ====================
            TAMGIAC tg;
            tg = XL_TAMGIAC.NhapTamGiac();
            double chuvi = XL_TAMGIAC.TinhChuVi(tg);
            Console.WriteLine($"Chu vi cua tam giac la {chuvi}");
            */

            /* ==================== XL_DIEM ====================
            DIEM a, b;
            Console.WriteLine("Nhap diem a:");
            a = XL_DIEM.NhapDiem();
            Console.WriteLine("Nhap diem b:");
            b = XL_DIEM.NhapDiem();

            string ToaDo_a = XL_DIEM.XuatDiem(a);
            Console.WriteLine($"Diem a {ToaDo_a}");
            string ToaDo_b = XL_DIEM.XuatDiem(b);
            Console.WriteLine($"Diem b {ToaDo_b}");
            double khoangcach = XL_DIEM.TinhKhoangCach(a, b);
            Console.WriteLine($"Khoang cach giua diem a va b la {khoangcach}");
            */

            /* ==================== XL_PHANSO ====================
            PHANSO a, b, sum;
            Console.WriteLine("Nhap phan so dau tien:");
            a = XL_PHANSO.NhapPhanSo();
            Console.WriteLine("Nhap phan so thu hai:");
            b = XL_PHANSO.NhapPhanSo();
            sum = XL_PHANSO.TinhTong(a, b);
            string chuoia = XL_PHANSO.XuatPhanSo(a);
            Console.WriteLine($"Phan so dau tien la {chuoia}");
            string chuoib = XL_PHANSO.XuatPhanSo(b);
            Console.WriteLine($"Phan so thu hai la {chuoib}");
            string kq_tong = XL_PHANSO.XuatPhanSo(sum);
            Console.WriteLine($"Phan so thu hai la {kq_tong}");
            */
  
            /* ==================== XL_MATRAN ====================
            // Nhap ma tran
            int[,] A = XL_MATRAN.NhapMaTran();
            XL_MATRAN.XuatMaTran(A);
            
            int sum = XL_MATRAN.TinhTong(A);
            Console.WriteLine($"Tong phan tu cua ma tran la {sum}");
            
            int maxi = XL_MATRAN.TimMax(A);
            Console.WriteLine($"Max cua ma tran la {maxi}");
            int nguyento = XL_MATRAN.DemNguyenTo(A);
            Console.WriteLine($"Ma tran co {nguyento} so nguyen to");
            int tongbien = XL_MATRAN.TongBien(A);
            Console.WriteLine($"Tong phan tu bien la {tongbien} ");
            int tong1dong = XL_MATRAN.Tong1Dong(A,3);
            Console.WriteLine($"Tong duong 1 dong la {tong1dong} ");

            int tongduong1cot = XL_MATRAN.TongDuong1Cot(A);
            Console.WriteLine($"Tong phan tu duong cua cot la {tongduong1cot} ");

            bool toanduong = XL_MATRAN.KiemTraToanDuong(A);
            Console.WriteLine($"Ma tran toan duong la {toanduong}");
  
            int k = 1;
            bool dongtang = XL_MATRAN.KiemTraDongTang(A, k);
            Console.WriteLine($"Dong {k} co phan tu tang la {dongtang}");
            

            bool giamdan = XL_MATRAN.KiemTraGiamDan(A);
            Console.WriteLine($"Giam dan la {giamdan}");
            

            int mode = XL_MATRAN.TimPhanTuXuatHienNhieuNhat(A);
            Console.WriteLine($"Phan tu xuat hien nhieu nhat {mode}");

            ==================== XL_MANG_1_CHIEU ====================
              
            // Nhap mang
            int[] A = XL_MANG.NhapMang();

            int[] B = XL_MANG.NhapMang();
            // Xuat mang vua nhap
            XL_MANG.XuatMang(A);
            XL_MANG.XuatMang(B);
            
            //Tinh tong cua phan tu trong mang
            int Tong = XL_MANG.TinhTong(A);
            Console.WriteLine($"Tong cua mang la {Tong}");

            // Tim min
            int BeNhat = XL_MANG.TimMin(A);
            Console.WriteLine($"Min cua mang la {BeNhat}");
            
            //Tim vi tri
            Console.WriteLine("Nhap gia tri muon tim trong mang: ");
            int n = int.Parse(Console.ReadLine());
            int v = XL_MANG.TimViTriXuatHien(A, n);
            Console.WriteLine($"Vi tri cua {n} o {v}");
            
            //Tim So duong dau tien
            int n = XL_MANG.TimSoDuongDauTien(A);
            Console.WriteLine($"So duong dau tien trong mang la {n}");
           
            // Tim so chan cuoi trong mang
            int n = XL_MANG.TimSoChanCuoiCung(A);
            Console.WriteLine($"So chan cuoi cung trong mang la {n}");
           
            //Thong ke so luong phan tu
            XL_MANG.ThongKePhanTu(A);
            
            //Kiem tra A trong B
            XL_MANG.TimAtrongB(A, B);
            */
        }
    }
}
