using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập vào số ngày thuê và loại phòng
            Console.Write("Nhập số ngày thuê: ");
            int ngayThue = int.Parse(Console.ReadLine());
            Console.Write("Nhập loại phòng (A, B, C): ");
            string loaiPhong = String.Format(Console.ReadLine().ToUpper());
            // Tính tiền thuê phòng theo quy định
            int donGia = 0;
            switch (loaiPhong)
            {
                case "A":
                    donGia = 250000;
                    break;
                case "B":
                    donGia = 200000;
                    break;
                case "C":
                    donGia = 150000;
                    break;
                default:
                    Console.WriteLine("Loại phòng không hợp lệ!");
                    return;
            }

            int tienThue = ngayThue * donGia;

            // Tính giảm giá nếu thuê quá 10 ngày
            if (ngayThue > 10)
            {
                int tienGiam = tienThue * 10/100;
                tienThue = tienThue - tienGiam;
            }

            // In kết quả
            Console.WriteLine("Tiền thuê phòng là: {0}", tienThue);
            Console.ReadLine();

        }
    }
}
