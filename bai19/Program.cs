using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bài 19: Viết chương trình nhập vào 1 mảng số nguyên có n phần tử. Đếm số phần tử dương, số phần tử âm, số phần tử bằng 0 trong mảng.
            int n;
            Console.Write("Nhap so phan tu cua mang: ");
            n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", i + 1);
                A[i] = int.Parse(Console.ReadLine());
            }
            int d = 0,a=0,k=0;
            for (int i = 0; i < n; i++)
                if (A[i] > 0)
                    d++;
                else if (A[i] < 0)
                    a++;
                else
                    k++;          
            Console.WriteLine("So phan tu duong trong mang la = " + d);
            Console.WriteLine("So phan tu am trong mang la = " + a);
            Console.Write("So phan tu bang 0 trong mang la = " + k);
            Console.ReadLine();
        }
    }
}
