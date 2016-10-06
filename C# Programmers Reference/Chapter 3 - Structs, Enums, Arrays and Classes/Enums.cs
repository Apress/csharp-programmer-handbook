/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 */
using System;

namespace Client.Chapter_3___Structs__Enums__Arrays_and_Classes
{
	enum DaysOfWeek
	{
		Monday,
		Tuesday,
		Wednesday,
		Thursday,
		Friday,
		Saturday,
		Sunday
	}
	class Enums
	{
		static void Main(string[] args)
		{
			DaysOfWeek Today = DaysOfWeek.Monday;

			Console.WriteLine(Today);
		}
	}
}
