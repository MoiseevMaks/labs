using System;

namespace Tool
{
    internal class Function
    {
        public static bool Compairing(int[] array1, int[] array2)
        {
            Array.Sort(array1);
            Array.Sort(array2);
            bool similar = true;
            for (int i = 0; i < array1.Length; i++)
            {
                if ((array1[i]) != (array2[i]))
                {
                    similar = false;
                }
                
            }
            return similar;
           
        }
    }
}
