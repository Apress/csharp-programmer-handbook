/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 */
using System;

namespace Client.Chapter_2___Common_Type_System
{
	class RelationalOperators
	{
		static void Main(string[] args)
		{
			int a, b;

			a = 1;
			b = 2;
			if (a > b)
				b = 10;

			if (b < a)
				a = 10;

			if (a >= b)
				b = 20;

			if (b <= a)
				a = 20;

			if (a == b)
				b = 5;

			if (b != a)
				b = a;
		}
	}
}
