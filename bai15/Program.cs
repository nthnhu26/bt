using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bài 15: Viết chương trình nhập vào một số nguyên dương n. Tính tổng của dãy số theo dạng sau:S = 1^1+ 2^2+ 3^3+ … +n^n
            int n;
            double s = 0;
            do
            {
                Console.Write("Nhap vao so nguyen duong n ");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                    if (i == j)
                        s = s + Math.Pow(i, j);
            Console.Write("Tong cua day so la " + s);
            Console.ReadLine();
        }
    }
}
