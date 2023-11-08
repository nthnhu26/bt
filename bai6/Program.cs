using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bài 6: Viết chương trình nhập vào hai số nguyên. Sau đó hiển thị ra màn hình menu các lựa chọn: 
            1. Thực hiện phép cộng 
            2. Thực hiện phép trừ
            3. Thực hiện phép nhân 
            4. Thực hiện phép chia 
            5. Thoát 
            Người dùng nhập vào các số từ 1 đến 4 để thực hiện lựa chọn của mình.*/

            int a,b,n;
            Console.Write("Nhap so a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b = ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Menu");
            Console.WriteLine("1. Thuc hien phep cong");
            Console.WriteLine("2. Thuc hien phep tru");
            Console.WriteLine("3. Thuc hien phep nhan");
            Console.WriteLine("4. Thuc hien phep chia");
            Console.WriteLine("5. Thoat");
            Console.Write("Nhap su lua chon cua ban la: ");
            n = int.Parse(Console.ReadLine());
            switch(n)
            {
                case 1:
                    Console.WriteLine("Tong cua a va b la: {0}", a + b);
                    break;
                case 2:
                    Console.WriteLine("Hieu cua a va b la: {0}", a - b);
                    break;
                case 3:
                    Console.WriteLine("Tich cua a va b la: {0}", a * b);
                    break;
                case 4:
                    if (b == 0)
                    {
                        Console.WriteLine("Mau so bang 0 nen khong the thuc hien chia");
                    }
                    else
                    {
                        Console.WriteLine("Thuong cua a va b la: {0}", a*1.0 / b);
                    }
                    break;
                case 5:
                    // Thoát khỏi vòng lặp
                    return;
                default:
                    Console.WriteLine("Lua chon khong hop le");
                    break;
            }
            Console.ReadLine();








        }
    }
}
