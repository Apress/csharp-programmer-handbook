using System;
using System.Runtime.InteropServices;

namespace Chapter10
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public struct MyName
	{
		public String first;
		public String last;
		public MyName(String first, String last)
		{
			this.first = first;
			this.last = last;
		}
	}
	public class PassingArrayStructs2
	{
		[DllImport("My.dll")]
		public static extern void ArrayOfStructs2([In, Out] MyName[] nameArray, int size);
		public static void Main()
		{
			MyName[] MyList = {
				new MyName("John", "Doe"), new MyName("Jane", "Doe"), new MyName("Jim", "Doe")
			};

			PassingArrayStructs2.ArrayOfStructs2(MyList, MyList.Length);
		}
	}
}      

