using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baisosanhtien
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 đại lượng số 1 bên 1000 tỷ và bên 1 ngàn đồng bên 1 ngàn đồng nhân đôi lên 30 ngày
            double tienty = 1000000000000;
            double tien = 1000;
            int ngay = 30;
            for (int i = 1; i <= ngay; i++)
            {
                tien *= 2;              
            }
            if (tien > tienty)
                Console.Write("Sau 30 thi so tien 1.000 dong nhan doi nhieu hon 1.000 ty dong {0} > {1}", tien,tienty);
            else
                Console.Write("Sau 30 thi so tien 1.000 ty dong nhieu hon 1.000 dong nhan doi {0} > {1} ", tienty,tien);
            Console.ReadLine();
        }
    }
}
