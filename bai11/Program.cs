using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bài 11: Viết chương trình tìm ước số chung lớn nhất của hai số.
            int a, b;        
            Console.Write("Nhập số nguyên dương a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhập số nguyên dương b: ");
            b = int.Parse(Console.ReadLine());
         
            int ucln = UCLN(a, b);
            Console.WriteLine("Ước số chung lớn nhất của {0} và {1} là: {2}", a,b,ucln);
            int bcnn = BCNN(a, b);
            Console.Write("Bội chung nhỏ nhất của {0} và {1} là: {2}", a, b, bcnn);
            Console.ReadLine();
        }
        static int UCLN(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return UCLN(b,a%b);

        }
        static int BCNN(int a, int b)
        {
            return a * b / UCLN(a, b);
        }
    }
}
