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
	class Expressions
	{
		static void Main(string[] args)
		{
			int 	MyInt = 12345;
			int		MyInt2 = 10000;
			int		Sum = 0;
			long 	MyLong = MyInt;
			short	MyShort = (short)MyInt;
			

			if (MyInt == MyInt2)
			{
				Sum = MyInt + MyInt2;
			}
			else
			{
				Sum = MyInt - MyInt2;
			}

		}
	}
}
