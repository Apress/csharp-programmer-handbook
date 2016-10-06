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
	class RemovingCharacters
	{
		static void Main(string[] args)
		{
			string MyString = "Hello UnderWorld";

			Console.WriteLine(MyString.Remove(7, 5));
		}
	}
}
