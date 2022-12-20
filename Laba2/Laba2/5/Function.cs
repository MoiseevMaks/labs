using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool
{
    internal class Function
    {
       public static int[] RemovingAllNegativeElementsInArray(int[] array)
        {
            int n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    n++;
                }
            }
            int m = 0;
            int[] array1 = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    array1[m] = array[i];
                    m++;
                }
            }
            return array1;
        }
    }
}
