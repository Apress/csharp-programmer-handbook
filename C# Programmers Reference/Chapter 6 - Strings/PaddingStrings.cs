/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 */
using System;

namespace Client.Chapter_6___Strings
{
	class PaddingStrings
	{
		static void Main(string[] args)
		{
			string MyString = "Hello World";

			Console.WriteLine(MyString.PadLeft(5));
		}
	}
}
