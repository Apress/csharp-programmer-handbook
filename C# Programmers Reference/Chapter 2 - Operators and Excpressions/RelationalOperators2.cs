/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 */
using System;

namespace Client.Chapter_2___Operators_and_Excpressions
{
	class RelationalOperators2
	{
		static void Main(string[] args)
		{
			int a = 10, b = 20, c = 30;

			if (a < 15 && b < 20)
				c = 10;

			if (a < 15 || b < 20)
				c = 15;

			if (!(a == 15))
				c = 25;
		}
	}
}
