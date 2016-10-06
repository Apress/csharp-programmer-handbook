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
	class StringConcatenation2
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter Your Password?");
			string UserPassword = Console.ReadLine();

			string Password = "Victory";
			if(Password.CompareTo(UserPassword) == 0)
				{
					Console.WriteLine("Bad Password");
				}

			Console.WriteLine("Good Password!");
		}
	}
}
