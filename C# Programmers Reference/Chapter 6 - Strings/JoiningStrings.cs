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
	class JoiningStrings
	{
		static void Main(string[] args)
		{
			string MyString = "Hello";
			string MyString2 = "World";
			string JoinedString = MyString + MyString2;

			Console.WriteLine(JoinedString);

			string[] A = new string[2] {
				"Hello", "World"
			};
			string Joined = string.Join(" ", A);

			Console.WriteLine(Joined);
		}
	}
}
