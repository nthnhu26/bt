using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("");
            //Bài 17: Viết chương trình nhập vào 1 mảng số nguyên có n phần tử. Kiểm tra trong mảng vừa nhập có số dương hay không.
            int n;
            Console.Write("Nhập số phần tử của mảng: ");
            n = int.Parse(Console.ReadLine());

            int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập phần tử thứ {0}: ", (i + 1));
                A[i] = int.Parse(Console.ReadLine());
            }
            //Kiểm tra mảng có số dương không.
            int c = 0;
            for (int i = 1; i < n; i++)
                if (A[i] > 0)
                {
                    c++;
                    break;
                }
            if(c!=0)
                Console.Write("Có số dương trong mảng");
            else
                Console.Write("Không có số dương trong mảng");

            Console.ReadLine();
        }
    }
}
