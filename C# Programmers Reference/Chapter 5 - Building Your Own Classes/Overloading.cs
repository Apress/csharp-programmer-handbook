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
	class OverloadingClasses
	{
		static void Main(string[] args)
		{
			A MyA = new A();

			MyA.Display();
			MyA.Display(10);
		}
	}
	public class A
	{
		public void Display()
		{
			Console.WriteLine("No Params Display Method");
		}
		public void Display(int A)
		{
			Console.WriteLine("Overloaded Display {0}", A);
		}
	}
}
