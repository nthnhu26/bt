using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Bài 5: Viết chương trình tính tiền đi taxi biết số km đã đi. Biết rằng: 1km đầu tiên giá
            5000 đồng. Từ km thứ 2 đến km thứ 5 giá trung bình là 4500 đồng/km. Từ km thứ 6 trở
            đi, giá trung bình mỗi km là 3500 đồng/km. Nếu khách hàng đi trên 120 km thì sẽ được
            giảm 10% trên tổng số tiền tính theo qui định */
            int sokm, tien = 0;
            Console.Write("Nhap so km di duoc ");
            sokm = int.Parse(Console.ReadLine());
            if (sokm <= 1)
            {
                tien = 5000;
            }
            else
                if (sokm <= 5)
                    tien = 5000 + 4 * 4500;
                else
                    tien = 5000 + 4 * 4500 + (sokm - 5) * 3500;
            if (sokm > 120)
                tien = tien * 90 / 100;
            Console.Write("So tien di taxi la {0} dong ", tien);
            Console.ReadLine();
        }
    }
}
