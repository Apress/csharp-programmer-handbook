using System;
using System.Runtime.InteropServices;

namespace Chapter10
{
	public class PassingArrayByValue
	{
		[DllImport("My.dll")]
		public static extern void ArrayOfInts([In, Out] int[] array, int size);
		public static void Main()
		{
			int[] array1 = new int[10];

			for (int i = 0; i < array1.Length; i++)
			{
				array1[i] = i;
			}

			PassingArrayByValue.ArrayOfInts(array1, array1.Length);
		}
	}
}
