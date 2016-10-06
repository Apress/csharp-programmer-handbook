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
	class DoWhile
	{
		static void Main(string[] args)
		{
			int a = 0;

			do
			{
				a++;
				Console.WriteLine(a);
			} while (a < 10);
		}
	}
}
