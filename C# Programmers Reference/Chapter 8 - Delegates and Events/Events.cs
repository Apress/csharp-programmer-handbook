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
	public delegate int MyDelegateEventHandler(MyEventArgs e);
	class MyEventSubscriber
	{
		static void Main(string[] args)
		{
			MyEventPublisher EventPublisher = new MyEventPublisher();
			MyEventArgs MyArgs = new MyEventArgs();

			MyArgs.MyString = "Hello World";
			EventPublisher.MyEvent += new MyDelegateEventHandler(MyHandler);
			EventPublisher.DoSomething(MyArgs);
		}
		static int MyHandler(MyEventArgs e)
		{
			Console.WriteLine(e.MyString);
			return 0;
		}
	}
	public class MyEventArgs: EventArgs
	{
		public int MyInt;
		public long MyLong;
		public string MyString;
	}
	public class MyEventPublisher
	{
		public event MyDelegateEventHandler MyEvent;
		public int DoSomething(MyEventArgs e)
		{
			MyEvent(e);
			return 0;
		}
	}
}
