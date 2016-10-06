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
	class BitwiseOperators
	{
		static void Main(string[] args)
		{
			long MyBit = 0x1;
			long MyBitResult = 0;

			MyBitResult = MyBit & 0x1;
			MyBitResult = MyBit | 0x2;
			MyBitResult = MyBit ^ 0x4;
		}
	}
}
