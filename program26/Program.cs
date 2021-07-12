using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program26
{
    class Program
    {
        static void Main(string[] args)
        {
            int MAX_SIZE = 1000;
            

            int[] a1 = new int[MAX_SIZE];
            Console.WriteLine("Enter number of elements :");
            int n = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\n Enter array elements \n");
            for (int i = 0; i < n; i++)
            {

                a1[i] = Convert.ToInt16(Console.ReadLine());

            }

            Console.WriteLine("Enter Search element\n");

            int x2 = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (a1[i] == x2)
                {
                    Console.WriteLine("Element {0} found at Position {1}\n", x2, i + 1);
                    flag = true;
                }

            }
            if (flag == true)
            {
                Console.WriteLine("item found");

            }
            else
            {
                Console.WriteLine("Not item found");
            }
            Console.ReadLine();

        }
    }
}
