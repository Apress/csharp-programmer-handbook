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
	class MyMainClass
	{
		static void Main(string[] args)
		{
			//The function called is based
			//upon the type called by new.
			B MyB = new C();
			D MyD = new D();

			MyB.Display();		//Calls C Display
			MyD.Display();		//Calls D Display
		}
	}
	public interface A
	{
		void Display();
	}
	class B: A
	{
		public virtual void Display()
		{
			Console.WriteLine("Class B's Display Method");
		}
	}
	class C: B
	{
		public override void Display()
		{
			Console.WriteLine("Class C's Display Method");
		}
	}
	class D: C
	{
		public override void Display()
		{
			Console.WriteLine("Class D's Display Method");
		}
	}

}
