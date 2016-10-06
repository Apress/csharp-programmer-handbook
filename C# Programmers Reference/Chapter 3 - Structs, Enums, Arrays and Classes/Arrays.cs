/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 */
using System;

namespace Client.Chapter_3___Structs__Enums__Arrays_and_Classes
{
	class Arrays1
	{
		static void Main(string[] args)
		{
			string[] MyStaticArray = { "Hello", "World" };
			int[] MyIntArray = new int[5];
			int i, z;

			for (int x = 0; x < 5; x++)
			{
				MyIntArray[x] = 0;
			}

			//an array of arrays OR JAGGED ARRAY
			int[][][] MyIntArray2 = new int[3][][];

			for (i = 0; i < 5; i++)
				MyIntArray2[i] = new int[4][];

			for (z = 0; z < 10; z++)
				MyIntArray2[i][z] = new int[5];

			//multidimensional array
			int[,] MyIntArray3 = new int[5, 5];

			for (int x = 0, y = 0; x < 5; x++, y++)
			{
				MyIntArray3[x, y] = 0;
			}
		}
	}
}
