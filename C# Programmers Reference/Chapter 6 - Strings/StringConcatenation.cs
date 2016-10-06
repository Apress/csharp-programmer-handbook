/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 */
using System;
using System.Text;

namespace Client.Chapter_6___Strings
{
	class StringConcatenation
	{
		static void Main(string[] args)
		{
		StringBuilder MyString = new
			StringBuilder("Hello");

		MyString.Insert(0, "My");
		MyString.Append("World");

		Console.WriteLine(MyString);

		}
	}
}
