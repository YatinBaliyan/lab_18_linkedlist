using System;
namespace lab18_linkedlists
{
	public class MyArray
	{
		public MyArray()
        {
            NumOfInts = numbers.Length;
        }
		public int NumOfInts { get; set; }

		int[] numbers = { 1, 2, 3, 2, 2, 4, 5, 5, 7, 8, 4, 4, 1, 0, 10 };
     

		public int[] CountEntries()
		{
			int[] numbers2 = new int[11];

			for (int i = 0; i < NumOfInts; i++)
			{
				if (numbers[i] >= 0 && numbers[i] <= 10)
					numbers2[numbers[i]]++;
			}
			return numbers2;
		}
	}
}
