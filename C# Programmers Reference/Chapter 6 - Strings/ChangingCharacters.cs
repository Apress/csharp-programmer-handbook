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
	class ChangingCharacters
	{
		static void Main(string[] args)
		{
			string MyString = "Miami, Dolphins";

			Console.WriteLine(MyString);
			MyString.ToUpper();
			Console.WriteLine(MyString);
			MyString.ToLower();
			Console.WriteLine(MyString);
		}
	}
}
