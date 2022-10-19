using System;


namespace Library1
{
    public static class Library
    {

        public static int[] CreatingArray()
        {
            int ammount;
            Console.WriteLine("Введите количество элементов массива :");
            bool result1 = int.TryParse(Console.ReadLine(), out  ammount);
            while( result1 == false && ammount <= 0)
            {
                Console.WriteLine("Значение введено неверно. Повторите попытку.");
                result1 = int.TryParse(Console.ReadLine(), out ammount);
            }
            int[] array1 = new int[ammount];
            return array1;
        }

        public static void FillingArray(int[] array)
        {
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < array.Length; i++)
            {
                bool result1 = int.TryParse(Console.ReadLine(), out array[i]);
                while (result1 == false)
                {
                    Console.WriteLine("Значение введено неверно. Повторите попытку.");
                    result1 = int.TryParse(Console.ReadLine(), out array[i]);
                }
            }
        }
        

        public static void Print1D(int[] array)
        {
            for( int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        
        public static void Random1D(int[] array)
        {
            Random randomGenerator = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomGenerator.Next(-100, 100);
            }
        }
    }
}

