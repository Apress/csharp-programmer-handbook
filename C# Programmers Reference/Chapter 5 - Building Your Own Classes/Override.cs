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
			A MyA = new D();
			B MyB = new C();

			MyA.Display();		//Calls D Display	
			MyB.Display();		//Calls C Display
			// followed by B's Display //via the base keyword
		}
	}
	class A
	{
		public virtual void Display()
		{
			Console.WriteLine("Class A's Display Method");
		}
	}
	class B: A
	{
		public override void Display()
		{
			Console.WriteLine("Class B's Display Method");
		}
	}
	class C: B
	{
		public override void Display()
		{
			Console.WriteLine("Class C's Display Method");
			base.Display();
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
