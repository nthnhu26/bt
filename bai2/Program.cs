using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Viết chương trình giải phương trình bậc hai. 
            double a, b, c;
            Console.Write("Nhap he so a ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Nhap he so b ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Nhap he so c ");
            c = double.Parse(Console.ReadLine());
            Phuongtrinh2(a, b, c);
            Console.ReadLine();



        }
        static void Phuongtrinh1(double a, double b)
        {
            if (a == 0)
                if (b == 0)
                    Console.Write("Phuong trinh co vo so nghiem");
                else
                    Console.Write("Phuong trinh vo nghiem");
            else
            {
                double x = -b / a;
                Console.Write("Phuong trinh co nghiem duy nhat x = " + x);
            }
        }
        static void Phuongtrinh2(double a, double b, double c)
        {
            if (a == 0)
                Phuongtrinh1(b, c);
            else
            {
                double d = b * b - 4 * a * c;
                if (d < 0)
                    Console.Write("Phuong trinh vo nghiem");
                if (d == 0)
                {
                    double x = -b / 2 * a;
                    Console.Write("Phuong trinh co nghiem kep x1 = x2 = " + x);
                }
                if (d > 0)
                {
                    double x1, x2;
                    x1 = (-b + Math.Sqrt(d)) / 2 * a;
                    x2 = (-b - Math.Sqrt(d)) / 2 * a;
                    Console.Write("Phuong trinh co nghiem x1 = {0} va x2 = {1}", x1, x2);
                }

            }
        }

    }
}
