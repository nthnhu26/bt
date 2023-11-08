using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7
{
    class Program
    {
        static void Main()
        {
            /*Bài 7: Viết chương trình cho phép nhập vào một số nguyên dương có 2 chữ số. Hãy in ra 
            cách đọc của số nguyên này. Ví dụ: 56: Năm mươi sáu, 15: Mười lăm, 21: Hai mươi 
            mốt…*/
            int n;
            do
            {
                Console.Write("Nhập số nguyên dương có hai chữ số: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 10 || n > 99);
            
            string cachDoc = DocSoHaiChuSo(n);
            Console.WriteLine(n + ": " + cachDoc);
            Console.ReadLine();
        }
        static string DocSoHaiChuSo(int so)
        {
            string[] donVi = {"", "một", "hai", "ba", "bốn", "lăm", "sáu", "bảy", "tám", "chín" };
            string[] hangChuc = {"", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };

            int chuc = so / 10;
            int donViChuSo = so % 10;
            if (chuc == 1)
                return "mười " + donVi[donViChuSo];
            else
                return hangChuc[chuc] + " " + donVi[donViChuSo];
         }
    }
}
