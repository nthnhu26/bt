using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap gio thu nhat (dinh dang HH:mm): ");
            string input1 = Console.ReadLine();
            TimeSpan time1 = TimeSpan.Parse(input1);

            Console.Write("Nhap gio thu hai (dinh dang HH:mm): ");
            string input2 = Console.ReadLine();
            TimeSpan time2 = TimeSpan.Parse(input2);

            TimeSpan sum = time1 + time2;
            TimeSpan diff = time1 > time2 ? time1 - time2 : time2 - time1;

            Console.WriteLine("Tong cua hai gio là: " + sum.ToString(@"hh\:mm"));
            Console.WriteLine("Hieu cua hai gio là: " + diff.ToString(@"hh\:mm"));

            Console.ReadLine();
        }
    }
}
