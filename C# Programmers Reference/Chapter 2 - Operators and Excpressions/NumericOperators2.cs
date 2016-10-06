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
	class NumericOperators2
	{
		static void Main(string[] args)
		{
			int 	a,b,c,d,e,f;

			a = 1;			//1

			b = a + 1;		//2
			b = b - 1;		//1

			c = 1; d = 2;	
			++c;			//2
			--d;			//1

			e = --c;		// e = 1 c = 1
			f = c--;		// f = 1 c = 0
		}
	}
}
