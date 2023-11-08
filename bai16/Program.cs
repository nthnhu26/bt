using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bài 16: Viết chương trình nhập vào một mảng một chiều. Tìm phần tử nhỏ nhất và lớn nhất của mảng.
            int n;           
            Console.Write("Nhập số phần tử của mảng: ");
            n = int.Parse(Console.ReadLine());

            int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập phần tử thứ {0}: ", (i+1));
                A[i] = int.Parse(Console.ReadLine());
            }
            //Tìm phần tử nhỏ nhất
            int min = A[0];
            for (int i = 1; i < n; i++)
                if (A[i] < min)
                    min = A[i];
            Console.WriteLine("Phần tử nhỏ nhất của mảng là MIN = " + min);
            //Tìm phần tử lớn nhất của mảng.
            int max = A[0];
            for (int i = 1; i < n; i++)
                if (A[i] > max)
                    max = A[i];
            Console.Write("Phần tử lớn nhất của mảng là MAX = " + max);

            Console.ReadLine();

        }
    }
}
