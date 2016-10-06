/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 */
using System;

namespace Client.Chapter_7___References__Pointers_and_Memory_Management
{
	class HeapandStackMemory
	{
		static void Main(string[] args)
		{
			MyClass ThisClass = new MyClass();
		}
	}
	public class MyClass
	{
		public int MyInt;
		private long MyLong;
		public void DoSomething()
		{
			Console.WriteLine(MyInt);
			Console.WriteLine(MyLong);
		}
	}
}
