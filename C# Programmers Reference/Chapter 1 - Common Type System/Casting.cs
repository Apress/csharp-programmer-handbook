/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 * Version: 1
 */
using System;

namespace Client.Chapter_1___Common_Type_System
{
	class Casting
	{
		static void Main(string[] args)
		{
			int MyInt = 12345;
			long MyLong = MyInt;	
			short MyShort = (short)MyInt;
		}
	}
}
