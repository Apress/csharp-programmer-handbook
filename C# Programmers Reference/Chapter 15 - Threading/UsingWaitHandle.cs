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
	public class ManagingThreads
	{
		public AutoResetEvent A = new AutoResetEvent(false);
		public AutoResetEvent[] B = new AutoResetEvent[3];
		public static int Main()
		{
			ManagingThreads M = new ManagingThreads();

			M.InitEvents();

			Thread T = new Thread(new ThreadStart(M.MyNewThread));

			T.Start();

			//T.Join();  //Blocks this thread until T Stops
			Console.WriteLine("Waiting!");
			M.A.WaitOne();
			WaitHandle.WaitAll(M.B);
			return 0;
		}
		public void InitEvents()
		{
			for (int i = 0; i < 3; i++)
			{
				B[i] = new AutoResetEvent(false);
			}
		}
		public void MyNewThread()
		{
			Console.WriteLine("MyNewThread Called");
			A.Set();
			B[0].Set();
			B[1].Set();
			B[2].Set();
		}
	}
}
