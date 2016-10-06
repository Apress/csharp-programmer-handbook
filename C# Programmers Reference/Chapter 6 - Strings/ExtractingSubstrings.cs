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
	class ExtractingSubstrings
	{
		static void Main(string[] args)
		{
			string MyClasses = "Math 101 – Algebra";
			string MySubstring = MyClasses.Substring(6);

			Console.WriteLine(MySubstring);
		}
	}
}
