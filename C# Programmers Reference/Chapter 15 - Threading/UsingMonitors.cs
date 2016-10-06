/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 * Version: 1
 */
using System;
using System.Collections;
using System.Threading;

namespace Client.Chapter_15___Threading
{
	class ThreadingClassMonitor
	{
		public static Thread ThreadOne = ThreadOne = new Thread(new ThreadStart(MonitorExample));
		public static ArrayList MyList = new ArrayList();
		public ThreadingClassMonitor()
		{
			MyList.Add("Test1");
			MyList.Add("Test2");
		}
		static void Main(string[] args)
		{
			ThreadOne.Start();
		}
		protected static void MonitorExample()
		{
			Monitor.Enter(MyList);
			MyList.Add("Test3");
			Monitor.Exit(MyList);
		}
	}
}
