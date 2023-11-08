﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bài 21: Viết chương trình nhập vào 1 mảng số nguyên có n phần tử. Tính tổng các phần tử là số chẵn trong mảng
            int n;
            Console.Write("Nhap so phan tu cua mang: ");
            n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", i + 1);
                A[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for(int i = 0; i < n; i++)
                if(A[i] % 2 == 0)
                    sum = sum + A[i];
            Console.Write("Tong cac phan tu chan trong mang la SUM = {0}", sum);
            Console.ReadLine();
        }
    }
}
