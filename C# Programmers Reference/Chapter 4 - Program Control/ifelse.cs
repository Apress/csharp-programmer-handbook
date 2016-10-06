/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 */
using System;

namespace Client.Chapter_4___Program_Control
{
	class ifelse
	{
		static void Main(string[] args)
		{
			int a = 5, b = 5, c = 10;

			if (a == b)
				Console.WriteLine(a);

			if ((a > c) || (a == b))
				Console.WriteLine(b);

			if ((a >= c) && (b <= c))
				Console.WriteLine(c);
		}
	}
}
