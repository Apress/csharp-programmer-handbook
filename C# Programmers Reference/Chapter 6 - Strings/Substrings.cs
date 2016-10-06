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
	class Substrings
	{
		static void Main(string[] args)
		{
			string[] FootballTeams = new string[3] {
				"Miami, Dolphins", "Oakland, Raiders", "Seattle, Seahawks"
			};

			foreach (string s in FootballTeams)
			{
				if (s.StartsWith("Miami"))
					Console.WriteLine("Awesome!");
				else
					Console.WriteLine("Bummer Dude!");
			}
		}
	}
}