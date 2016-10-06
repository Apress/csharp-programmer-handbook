/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 * Version: 1
 */
using System;
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
			IAsyncResult ar = X.BeginInvoke("Hello", ref a, ref b, null, null);

			ar.AsyncWaitHandle.WaitOne(10000, false);
			if (ar.IsCompleted)
			{
				int c = 0;
				int d = 0;

				//get results
				X.EndInvoke(ref c, ref d, ar);
				Console.WriteLine(c);
				Console.WriteLine(d);
			}
		}
		//My Async Method
		static int DoSomething(string s, ref int a, ref int b)
		{
			a = 10;
			b = 100;
			Console.WriteLine("Fired! DoSomething1");
			return 0;
		}
	}
}
