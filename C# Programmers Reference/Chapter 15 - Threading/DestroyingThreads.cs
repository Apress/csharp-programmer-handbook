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
	class DestroyingThreads
	{
		static int MyCount = 0;
		static void Main(string[] args)
		{
			MyClassThread me = new MyClassThread();
			Thread MyNewThread = new Thread(new ThreadStart(me.MyThread));

			MyNewThread.Start();
			if (MyCount == 0)
				MyNewThread.Abort();
		}
	}
	class MyClassThread
	{
		public void MyThread()
		{
		}
	}

}
