using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Viết chương trình nhập vào một số nguyên dương n. Tính tổng của dãy số sau: S = 1 + 2 + 3 + ... + n
            int n, s = 0;
            do
            {
                Console.Write("Nhap vao so nguyen duong n ");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);
            for (int i = 1; i <= n; i++)
                s += i;
            Console.Write("Tong cua day so la " + s);
            Console.ReadLine();
        }
    }
}
