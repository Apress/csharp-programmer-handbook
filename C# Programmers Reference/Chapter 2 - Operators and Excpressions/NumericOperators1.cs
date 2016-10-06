/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 * Version: 1
 */
using System;

namespace Client.Chapter_2___Operators_and_Excpressions
{
	class NumericOperators1
	{
		static void Main(string[] args)
		{
			int a, b, c, d, e;

			a = 1;
			a += 1;
			b = a;
			b -= 2;
			c = b;
			c *= 3;
			d = 4;
			d /= 2;
			e = 23;
			e %= 3;
		}
	}
}
