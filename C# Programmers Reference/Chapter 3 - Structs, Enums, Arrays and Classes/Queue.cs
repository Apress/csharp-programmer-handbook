/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 */
using System;
using System.Collections;

namespace Client.Chapter_3___Structs__Enums__Arrays_and_Classes
{
	class Queues
	{
		static void Main(string[] args)
		{
			Queue a = new Queue(10);
			int x = 0;

			a.Enqueue(x);
			x++;
			a.Enqueue(x);
			foreach (int y in a)
			{
				Console.WriteLine(y);
			}

			a.Dequeue();
			a.Clear();
		}
	}
}
