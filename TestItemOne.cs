using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class TestItemOne
    {
        public static void RunTestItemOne()
        {

            int[] SampleNumbers = new int[] { 5, 1, 4, 6, 7, 3, 5, 7, 3 };
            List<int> DuplicateNumbers = new();
            for(int a = 0; a<SampleNumbers.Length; a++)
            {
            int occurrence = SampleNumbers.Where(x => x == SampleNumbers[a]).Count();
                    if (occurrence > 1)
                        DuplicateNumbers.Add(SampleNumbers[a]);
            }
            string outputThis = string.Join(", ", DuplicateNumbers.Distinct());
            Console.WriteLine(outputThis);
            return;
	    }

    }
}
