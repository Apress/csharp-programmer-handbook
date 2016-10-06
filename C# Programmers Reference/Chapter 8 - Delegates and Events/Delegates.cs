/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 */
using System;

namespace Client.Chapter_8___Delegates_and_Events
{
	class Delegates
	{
		delegate int MyDelegate(string s);
		static void Main(string[] args)
		{
			MyDelegate Del1 = new MyDelegate(DoSomething);
			MyDelegate Del2 = new MyDelegate(DoSomething2);
			string MyString = "Hello World";

			Del1(MyString);
			Del2(MyString);

			//Or you can Multicast delegates by doing this
			MyDelegate Multicast = null;

			Multicast += new MyDelegate(DoSomething);
			Multicast += new MyDelegate(DoSomething2);

			//Both DoSomething & DoSomething2 will be fired
			//in the order they are added to the delegate
			Multicast(MyString);
			Multicast -= new MyDelegate(DoSomething2);
		}
		static int DoSomething(string s)
		{
			return 0;
		}
		static int DoSomething2(string s)
		{
			return 0;
		}
	}
}
