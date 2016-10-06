/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 */
using System;
using System.Collections;

namespace Client.Chapter_3___Structs__Enums__Arrays_and_Classes
{
	class Stacks
	{
		static void Main(string[] args)
		{
			Stack a = new Stack(10);
			int x = 0;

			a.Push(x);
			x++;
			a.Push(x);
			foreach (int y in a)
			{
				Console.WriteLine(y);
			}

			a.Pop();
			a.Clear();
		}
	}
}
