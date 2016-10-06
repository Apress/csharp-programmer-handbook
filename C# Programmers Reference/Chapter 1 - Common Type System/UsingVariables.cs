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
	class UsingVariables
	{
		static void Main(string[] args)
		{
			int MyInt = 12345;
			int MyInt2 = MyInt + 1;
			int MyInt3;

			MyInt3 = My2ndFunction(MyInt2);
		}
		static public int My2ndFunction(int myInt2)
		{
			myInt2 = myInt2 * 2;
			return myInt2;
		}
	}

}
