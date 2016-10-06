using System;
using System.Runtime.InteropServices;

namespace Chapter10
{
	[StructLayout(LayoutKind.Sequential)]
	public struct MyStruct
	{
		public int x;
		public int y;
		public MyStruct(int x, int y)
		{
			this.x = x;
			this.y = y;
		}
	}
	public class PassingArrayOfStructs
	{
		[DllImport("My.dll")]
		public static extern void ArrayOfStructs([In, Out] MyStruct[] structArray, int size);
		public static void Main()
		{
			MyStruct[] points = {
				new MyStruct(1, 1), new MyStruct(2, 2), new MyStruct(3, 3)
			};

			PassingArrayOfStructs.ArrayOfStructs(points, points.Length);
		}
	}
}

