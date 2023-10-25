using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lopduan
{
    internal class Program
    {
        static void Main(string[] args)
        {

            lopduan lopduan = new lopduan();
            Console.WriteLine("nhap so luong du an: ");
            int n = Convert.ToInt16(Console.ReadLine());
            lopduan[] danhsach = new lopduan[n];
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("nhap thong tin du an thu: " + (i + 1));


                danhsach[i] = new lopduan();
                danhsach[i].nhap();
                

            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("thong tin du an thu " + (i + 1));
                danhsach[i].xuat();
                danhsach[i].tinhTD();
            }
            

            Console.ReadKey();
        }
    }
}
