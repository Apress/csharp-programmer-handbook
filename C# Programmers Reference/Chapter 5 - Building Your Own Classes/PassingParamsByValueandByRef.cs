/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 */
using System;

namespace Client.Chapter_5___Building_Your_Own_Classes
{
	class PassingParametersByValueandByRef
	{
		static void Main(string[] args)
		{
			int MyInt = 5;

			MyIntArray = new int[10];
			ObjectCount++;
			Method2();
			Method2(1, 2);
			MyMethodRef(ref MyInt);
			Method2(new int[] { 1, 2, 3, 4 });
		}
		static private int MyInt = 5;
		static public int MyInt2 = 10;
		static public int[] MyIntArray;
		private static int ObjectCount = 0;
		static public int MyMethodRef(ref int myInt)
		{
			MyInt = MyInt + myInt;
			return MyInt;
		}
		static public int MyMethod(int myInt)
		{
			MyInt = MyInt + myInt;
			return MyInt;
		}
		static private long MyLongMethod(ref int myInt)
		{
			return myInt;
		}
		static public void Method2(params int[] args)
		{
			for (int I = 0; I < args.Length; I++)
				Console.WriteLine(args[I]);
		}
	}
}
