using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In ra cac bang cuu chuong\n");
            for (int i = 2; i <= 9; i++)
            {
                Console.WriteLine("Bang cuu chuong {0}:\n", i);
                for (int j = 1; j <= 10; j++)
                {
                    if (j < 10)
                    {
                        if (i * j < 10)
                            Console.WriteLine("{0} *  {1} =  {2}", i, j, i * j);
                        else
                            Console.WriteLine("{0} *  {1} = {2}", i, j, i * j);
                    }

                    else
                    {
                        Console.WriteLine("{0} * {1} = {2}", i, j, i * j);

                    }

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
