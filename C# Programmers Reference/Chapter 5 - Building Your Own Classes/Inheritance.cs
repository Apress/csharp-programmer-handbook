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
	class Inheritance
	{
		static void Main(string[] args)
		{
			B MyB = new D();
			D MyD = new D();

			//Both result in in D’s instance of Display being //called
			MyB.Display();
			MyD.Display();
		}
	}
	public class B
	{
		public virtual void Display()
		{
			Console.WriteLine("Class B's Display Method");
		}
	}
	public class C: B
	{
		public override void Display()
		{
			Console.WriteLine("Class C's Display Method");
		}
	}
	public class ContainedClass
	{
		int MyInt = 0;
	}
	public class D: C
	{
		public ContainedClass MyClass = new ContainedClass();
		public override void Display()
		{
			Console.WriteLine("Class D's Display Method");
		}
	}

}
