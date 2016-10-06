/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 */
using System;

namespace Client.Chapter_5___Building_Your_Own_Classes
{
	class DeclaringClassInstances
	{
		static void Main(string[] args)
		{
			ClassInstantied MyClass = new ClassInstantied();
		}
	}
	public class ClassInstantied
	{
		public void Display()
		{
			Console.WriteLine("Hello World");
		}
	}
}
