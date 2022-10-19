using System;
using Library1;
namespace z7
{
	internal class Program
	{
		static void Main(string[] args)
		{


			int[] array = Library.CreatingArray();
			Library.FillingArray(array);
			Array.Sort(array);
			Array.Reverse(array);
			Console.Write("\nСортированный массив: ");
			Library.Print1D(array);
		}
	}
}

