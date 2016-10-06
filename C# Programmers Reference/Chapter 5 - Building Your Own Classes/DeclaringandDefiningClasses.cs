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
	public class DeclaringandDefiningClasses
	{
		static private int MyInt = 5;
		static public int MyInt2 = 10;
		static public int[] MyIntArray;
		static private int ObjectCount = 0;
		static void Main(string[] args)
		{
			MyIntArray = new int[10];
			ObjectCount++;
		}
		public static int MyMethod(int myInt)
		{
			MyInt = MyInt + myInt;
			return MyInt;
		}
		private static long MyLongMethod(ref int myInt)
		{
			return myInt;
		}
	}
}
