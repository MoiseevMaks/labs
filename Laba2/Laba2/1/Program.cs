using System;
using Library1;


namespace z1
{
	internal class Program
	{
		public static void Main()
		{
			int[] array = new int[20];
			Library.Random1D(array);
			Library.Print1D(array);
			Tool.Function.SortByMax(array);
			Console.Write("\nОтсортированный массив : ");
			Library.Print1D(array);
			Console.WriteLine("\nМинимальное значение = {0}", Tool.Function.FindingMin(array));
			Console.WriteLine("Максимальное значение = {0}", Tool.Function.FindingMax(array));
			Console.ReadLine();
		}

	}
}

