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
	class IdentifiersandNaming
	{
		static void Main(string[] args)
		{
			int MyInt = 12345;
			long MyLong = MyInt;
			short MyShort = (short)MyInt;

			My2ndFunction(MyInt);
		}
		public static int My2ndFunction(int myInt)
		{
			return myInt;
		}
	}

}
