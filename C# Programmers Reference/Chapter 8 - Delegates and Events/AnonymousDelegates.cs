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
	public delegate void MyDelegateEventHandler(int i);
	class MyEventSubscriber
	{
		static void Main(string[] args)
		{
			MyEventPublisher EventPublisher = new MyEventPublisher();
			

			MyDelegateEventHandler MyAnonymousDelegate = delegate(int x)
			{
				Console.WriteLine("Anonymous Event FIRED!");
			};

			EventPublisher.MyEvent += MyAnonymousDelegate;
			
			EventPublisher.DoSomething();
		}
		
	}
	
	public class MyEventPublisher
	{
		public event MyDelegateEventHandler MyEvent;
		public int DoSomething()
		{
			MyEvent(5);
			return 0;
		}
	}

}
