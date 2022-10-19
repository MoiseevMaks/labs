using System;


namespace Tool
{
    public static class Function
    {
		 public static void SortByMax(int[] array)
		 {
			for (int i = 0; i < array.Length - 1; i++)
			{
				for (int j = i + 1; j < array.Length; j++)
				{
					if (array[i] > array[j])
					{
						int t = array[i];
						array[i] = array[j];
						array[j] = t;
					}
				}
			}
		 }

		public static int FindingMax(int[] array)
        {
			int max = array[0];
			for (int i = 0; i < array.Length; i++)
            {
				if (array[i] > max)
                {
					max = array[i];
                }
            }
			return max;
        }

		public static int FindindMin(int[] array)
		{
			int min = array[0];
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] < min)
				{
					min = array[i];
				}
			}
			return min;
		}
	}
}
