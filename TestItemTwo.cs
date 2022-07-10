using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    public class TestItemTwo
    {
        public static void RunTestItemTwo()
        {
            int[] SampleNumbers = new int[] { 1, 2, 3, 4, 5, 6 };
            for (int a = 0; a < SampleNumbers.Length; a++)
            {
                NumberPrinter(SampleNumbers[a]);
            }

            void NumberPrinter(int num)
            {
                for (int i = 0; i < num; i++)
                {
                    Console.Write(num);
                }
                Console.WriteLine();
            }

        }
    }
}
