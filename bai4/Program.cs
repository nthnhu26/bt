using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            // Nhập vào 4 số nguyên
            Console.WriteLine("Nhap so nguyen a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen c: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen d: ");
            d = int.Parse(Console.ReadLine());

            // Tìm số lớn nhất
            int max1 = Math.Max(a, b);
            int max2 = Math.Max(c, d);
            int max = Math.Max(max1, max2);


            // In ra màn hình số lớn nhất
            Console.WriteLine("So lon nhat la: " + max);
            Console.ReadKey();
        }
    }
}
