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
	class MyMainClass
	{
		public static ManualResetEvent MyManualEvent = new ManualResetEvent(false);
		public static AutoResetEvent MyAutoEvent = new AutoResetEvent(false);
		static void Main(string[] args)
		{
			ThreadPool.QueueUserWorkItem(new WaitCallback(DoBackgroundWorkManual));
			MyManualEvent.WaitOne();
			MyManualEvent.Reset();  //Sets the Event back to nonsignaled
			ThreadPool.QueueUserWorkItem(new WaitCallback(DoBackgroundWorkAuto));
			MyAutoEvent.WaitOne();
		}
		public static void DoBackgroundWorkManual(Object state)
		{
			Console.WriteLine("Thread 1");
			//Do stuff 
			//Then release control back to the main thread
			MyManualEvent.Set(); //Signals the event
		}
		public static void DoBackgroundWorkAuto(Object state)
		{
			Console.WriteLine("Thread 1");
			//Do stuff 
			MyAutoEvent.Set();
		}
	}
}
