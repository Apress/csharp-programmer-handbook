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
	public class List
	{
		internal object[] elements;
		internal int count;
		public IEnumerable Elements()
		{
			foreach (object o in elements)
			{
				yield o;
			}
		}
	}
	public class ListUser
	{
		static void Main(string[] args)
		{
			List list = new List();
			foreach (object obj in list.Elements())
			{
				// do something with obj
			}
		}
	}
}
