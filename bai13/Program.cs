using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bài 13: Viết chương trình nhập vào một số nguyên dương n. Tính tổng của dãy số sau: S=1/2+1/4+1/8+...+1/2^n
            int n;
            double s = 0;
            do
            {
                Console.Write("Nhap vao so nguyen duong n ");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);
            for (int i = 1; i <= n; i++)
                s += 1 / Math.Pow(2, i);
            Console.Write("Tong cua day so la " + s);
            Console.ReadLine();
        }
    }
}
