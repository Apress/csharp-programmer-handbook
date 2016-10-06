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
			WhileContinue();
			WhileBreak();
			WhileGoto();
		}
		static void WhileContinue()
		{
			int a = 0;
			
			while(a < 10)
			{
				a++;
				if (a == 5)
				{
					a++;
					continue;
				}
			}

		}
		static void WhileBreak()
		{
			int a = 0;

			while (a < 10)
			{
				a++;
				if (a == 5)
					break;
			}

			a++;
		}
		static void WhileGoto()
		{
			int a = 0;

			while (a < 10)
			{
				if (a == 5)
					goto cleanup;
			}
		cleanup :

			Console.WriteLine(a);
		}
	}
}
