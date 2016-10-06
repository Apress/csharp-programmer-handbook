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

namespace Client.Chapter_15___Threading
{
	public class TimerDemo
	{
		public static AutoResetEvent A = new AutoResetEvent(false);
		public static int index = 0;
		public static int Main()
		{
			Timer T = new Timer(new TimerCallback(TimerDemo.DoUpdates), null, 5000, 10000);

			A.WaitOne();
			Console.WriteLine("Main Thread event signaled");
			T.Dispose();
			return 0;
		}
		public static void DoUpdates(object state)
		{
			Console.WriteLine("DoUpdates");
			if (index == 5)
				A.Set();

			index++;
			Console.WriteLine(index);
		}
	}
}
