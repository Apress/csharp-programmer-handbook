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
	class TrimmingSpaces
	{
		static void Main(string[] args)
		{
			string MyString = "   Hello, World !  ";

			MyString.TrimStart();
			Console.WriteLine(MyString);
			MyString.TrimEnd();
			Console.WriteLine(MyString);
			MyString.Trim(char.Parse("!"));
			Console.WriteLine(MyString);
		}
	}
}
