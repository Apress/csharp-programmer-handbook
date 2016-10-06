/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 */
using System;

namespace Client.Chapter_4___Program_Control
{
	class MyMainClass
	{
		static void Main(string[] args)
		{
			int a = 0;
			Console.ReadLine();

			switch (a)
			{
				case 1:
					Console.WriteLine("One");
					break;
				case 2:
					Console.WriteLine("Two");
					break;
				default:
					Console.WriteLine("?");
					break;

			}
		}
	}
}
