using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Viết chương trình nhập vào điểm 3 môn học: Toán, Lý, Hóa. Tính và xuất điểm trung bình cộng điểm 3 môn
            double toan, ly, hoa, tb;
            Console.Write("Nhap diem toan ");
            toan = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem ly ");
            ly = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem hoa ");
            hoa = double.Parse(Console.ReadLine());
            tb = (toan + ly + hoa) / 3;
            Console.Write("Diem trung binh cong diem 3 mon la " + tb);
            Console.ReadLine();
        }
    }
}
