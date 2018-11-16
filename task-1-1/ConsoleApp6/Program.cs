using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class _Main
    {
        const int maxValue = 100;  

        static void Main()
        {
            Random random = new Random();
            int[] array = new int[20];

            int value = random.Next(maxValue), i = 0;
            array[i++] = value;

            while (true)
            {
                value = random.Next(maxValue);
                if (!Contains(array, value))
                    array[i++] = value;

                if (i == array.Length) break;
            }

            //Output:
            foreach (var tmp in array)
                Console.Write("{0} ", tmp);

            Console.ReadKey();
        }

        static bool Contains(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] == value)
                    return true;
            return false;
        }
    }
}
