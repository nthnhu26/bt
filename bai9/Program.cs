using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bài 9: Giả sử lương của công nhân được tính theo công thức: 
            Tiền lương = (mức lương mỗi ngày * số ngày) + tiền thưởng - tiền phạt. 
            Biết rằng tiền thưởng bao gồm 2 khoản: 
            1. Tiền thưởng thêm cho mỗi giờ làm việc tăng ca là 10000 đồng. 
            2. Tiền thưởng thêm cho mỗi ngày là 15000 đồng kể từ ngày làm việc thứ 25 trở đi nếu số ngày làm việc lớn hơn 24 ngày. 
            Tiền phạt đối với mỗi ngày đi trễ là 20000 đồng. 
            Viết chương trình nhập vào mức lương mỗi ngày, số ngày làm việc, số giờ làm việc tăng ca, số ngày đi trễ, tính và in ra tiền lương của công nhân.*/
            Console.Write("Nhập mức lương mỗi ngày: ");
            int mucluongmoingay = int.Parse(Console.ReadLine());
            Console.Write("Nhập số ngày làm việc: ");
            int songaylamviec = int.Parse(Console.ReadLine());
            Console.Write("Nhập số giờ làm việc tăng ca: ");
            int sogiotangca = int.Parse(Console.ReadLine());
            Console.Write("Nhập số ngày đi trễ: ");
            int songayditre = int.Parse(Console.ReadLine());

            int tienthuongtangca = sogiotangca*10000;
            int tienthuongngay = 0;
            if(songaylamviec>24)
                tienthuongngay = 15000;
            int tienthuong = tienthuongtangca + (songaylamviec - 24) * tienthuongngay;
            int tienphat = songayditre*20000;
            int tienluong = ( mucluongmoingay * songaylamviec ) + tienthuong - tienphat;
            Console.Write("Tiền lương của công nhân là " + tienluong);           
            Console.ReadLine();


        }
    }
}
