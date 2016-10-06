/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 * Version: 1
 */
using System;
using System.Threading;
using System.Runtime.Remoting.Messaging;

namespace Client.Chapter_15___Threading
{
	class MyMainClass
	{
		delegate int MyDelegate(string s, ref int a, ref int b);
		static void Main(string[] args)
		{
			MyDelegate X = new MyDelegate(DoSomething);
			int a = 0;
			int b = 0;

			//Making Async Call that calls a callback when finished
			AsyncCallback cb = new AsyncCallback(DoSomething2);
			IAsyncResult ar = X.BeginInvoke("Hello", ref a, ref b, cb, null);

			Console.ReadLine();
		}
		//My Async Method
		static int DoSomething(string s, ref int a, ref int b)
		{
			a = 10;
			b = 100;
			Console.WriteLine("Fired! DoSomething1");
			return 0;
		}
		//Mycallback method when finished running DoSomehting
		static void DoSomething2(IAsyncResult ar)
		{
			int a = 0;
			int b = 0;

			Console.WriteLine("Fired! DoSomething2");

			//Get the delegate
			MyDelegate X = (MyDelegate)((AsyncResult)ar).AsyncDelegate;

			//get results
			X.EndInvoke(ref a, ref b, ar);
			Console.WriteLine(a);
			Console.WriteLine(b);
		}
	}

}
