using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bài 10: Viết chương trình nhập vào 1 số nguyên dương N. Liệt kê ra màn hình tất cả các 
            ước số của số nguyên N. Ví dụ: N=12. Các ước số của N là: 1, 2, 3, 4, 6, 12.*/
            int n;
            do
            {
                Console.Write("Nhập số nguyên dương n: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 1);
            Console.Write("Các ước số của {0} là: ",n);
            for(int i=1; i<=n;i++)
                if(n%i==0)
                    Console.Write(i + " ");
            Console.ReadLine();

        }
    }
}
