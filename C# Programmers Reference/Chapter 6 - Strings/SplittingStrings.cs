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
	class SplittingStrings
	{
		static void Main(string[] args)
		{
			string MyString = "The quick brown fox ran around!";
			string[] MyStringSplit = new string[6];

			MyStringSplit = MyString.Split(new char[] { ' ' }, 6);
			Console.WriteLine(MyStringSplit[1] + MyStringSplit[3]);
		}
	}
}
