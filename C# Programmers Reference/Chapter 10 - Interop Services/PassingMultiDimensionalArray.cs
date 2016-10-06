using System.Runtime.InteropServices;

namespace Chapter10
{
	public class PassingMultiOfInts
	{
		[DllImport("My.dll")]
		public static extern void MultiOfInts([In, Out] int[,] pMulti, int row);
		public static void Main()
		{
			const int DIM = 10;
			int[,] multi = new int[DIM, DIM];

			for (int i = 0; i < DIM; i++)
			{
				for (int j = 0; j < DIM; j++)
				{
					multi[i, j] = j;
				}
			}

			PassingMultiOfInts.MultiOfInts(multi, DIM);
		}
	}
}
