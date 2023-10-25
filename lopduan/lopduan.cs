using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace lopduan
{
    internal class lopduan
    {
        public string tenduan;
        public DateTime ngaybatdau;
        public DateTime ngayketthuc;
        public lopduan()
        {

        }
        public lopduan(string tenduan, DateTime ngaybatdau, DateTime ngayhientai, DateTime ngayketthuc)
        {
            tenduan = tenduan;
            ngaybatdau = ngaybatdau;
            ngayketthuc = ngayketthuc;
        }

        public void nhap()
        {
            Console.WriteLine(" nhap ten du an: ");
            tenduan = Console.ReadLine();
            Console.WriteLine("nhap ngay bat dau: ");
            ngaybatdau =  DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.WriteLine("nhap ngay ket thuc:");
            ngayketthuc = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        }
        public void xuat()
        {
            Console.WriteLine("ten du an la: " + tenduan);
            Console.WriteLine("ngay ket thuc la: " + ngaybatdau.ToString("dd/MM/yyyy"));
            Console.WriteLine("ngay ket thuc la: " + ngayketthuc.ToString("dd/MM/yyyy"));
        }
       public void tinhTD()
        {
            DateTime today = DateTime.Today;
            TimeSpan tiendo;
            if (ngayketthuc > today)
            {
                tiendo = today - ngaybatdau;
            }
            else
            {
                tiendo = ngayketthuc  - ngaybatdau;
            }
            double totalDays = (ngayketthuc - ngaybatdau).TotalDays;
            double completedDays = tiendo.TotalDays;
            if (totalDays <= 0)
            {
                Console.WriteLine("Ngày kết thúc phải lớn hơn ngày bắt đầu.");
            }
            else
            {

                if (ngayketthuc > today)
                {
                    double progress = (completedDays / totalDays) * 100;
                    string phantramtiendo = progress.ToString("F2");
                    Console.WriteLine(" tien do du an la: " + completedDays + " va da hoan thanh "+ phantramtiendo+ "%");
                    
                }
                else
                {
                    double progress = (completedDays / totalDays) * 100;
                    string phantramtiendo = progress.ToString("F2");
                    Console.WriteLine(" tien do du an la: " + totalDays + " va da hoan thanh " + phantramtiendo + "%");
                }
            }

        }
       
    }

        
}
