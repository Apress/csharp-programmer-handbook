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
	public class ThreadTest
	{
		public static int Main()
		{
			Thread X = new Thread(new ThreadStart(SecondThread));

			X.Start();

			//Cause the second thread to resume
			X.Interrupt();

			//Place the second thread in a suspended state
			X.Suspend();

			//do some work and restart the thread
			X.Resume();

			//force this thread to wait until the seond thread is finished
			X.Join();
			return 0;
		}
		public static void SecondThread()
		{
			Console.WriteLine("Running second thread");
			//Place the second thread a sleep infinitly
			try
			{
				Thread.Sleep(Timeout.Infinite);
			}
			catch (ThreadInterruptedException e)
			{
				Console.WriteLine("Thread Interupted");
			}
			catch(ThreadAbortException e)
			{
				Thread.ResetAbort();
			}
		}
	}
}
