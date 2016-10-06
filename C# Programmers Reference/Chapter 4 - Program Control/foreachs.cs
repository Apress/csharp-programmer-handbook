/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 */
using System;
using System.Collections;

namespace Client.Chapter_4___Program_Control
{
	class ForEaches
	{
		static void Main(string[] args)
		{
			ArrayList a = new ArrayList(10);

			foreach (int x in a)
			{
				Console.WriteLine(x);
			}
		}
	}
}
