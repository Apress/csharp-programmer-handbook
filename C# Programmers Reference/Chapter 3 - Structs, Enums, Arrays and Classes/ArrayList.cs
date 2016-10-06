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
	class MyArrayList
	{
		static void Main(string[] args)
		{
			ArrayList a = new ArrayList(10);
			ArrayList.Synchronized(a);
			int x = 0;

			a.Add(x);
			a.Insert(1, ++x);
			foreach (int y in a)
			{
				Console.WriteLine(y);
			}

			a.Remove(x);
			a.RemoveAt(0);
			a.Clear();
		}
	}
}
