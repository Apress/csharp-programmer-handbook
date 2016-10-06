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
	class Arrays2
	{
		static void Main(string[] args)
		{
			//multidimensional array
			int[,] MyIntArray = new int[5, 5];

			for (int x = 0, y = 0; x < 5; x++, y++)
			{
				MyIntArray[x, y] = 0;
			}
		}
	}
}
