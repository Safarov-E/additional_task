using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int max = 20;
            int[] x = new int[max];

            for (int i = 0; i < max; i++)
            {
                bool contains;
                int next;
                do
                {
                    next = r.Next(max);
                    contains = false;
                    for (int index = 0; index < i; index++)
                    {
                        int n = x[index];
                        if (n == next)
                        {
                            contains = true;
                            break;
                        }
                    }
                } while (contains);
                x[i] = next;


            }

            foreach (int i in x)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

        }
    }
}
