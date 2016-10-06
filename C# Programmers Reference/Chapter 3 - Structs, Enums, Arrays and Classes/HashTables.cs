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
	class HashTables
	{
		static void Main(string[] args)
		{
			Hashtable a = new Hashtable(10);
			Hashtable.Synchronized(a);
						
			a.Add(100, "Arrays");
			a.Add(200, "Classes");
			

			foreach(DictionaryEntry d in a)
			{
				Console.WriteLine(d.Value);
			}

			a.Remove(100);
			a.Remove(200);
			a.Clear();

		}
	}
}
