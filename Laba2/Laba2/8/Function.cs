using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool
{
    internal class Function
    {
        public static void Random1D(int[] array)
        {
            Random randomGenerator = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomGenerator.Next(0, 10);
            }
        }

        public static int[] SearchElement(int[] array)
        {
            Console.Write("\nИскомое значение = ");
            bool result1 = int.TryParse(Console.ReadLine(), out int number);
            int ammount = 0;
            int index = 0;
            int[] arrayIndex = new int[array.Length];
            if (result1 == true)
            {
                while (Array.IndexOf(array, number, index ) != -1) 
                {
                    arrayIndex[ammount] = Array.IndexOf(array, number, index);
                    index = arrayIndex[ammount] + 1;                        
                    ammount++;
                }
                
            }
            Array.Resize(ref arrayIndex, ammount);
            return arrayIndex;
        }
    }
}
