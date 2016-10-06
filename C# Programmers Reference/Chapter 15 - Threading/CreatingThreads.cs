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
	class CreatingThreads
	{
		static void Main(string[] args)
		{
			Thread MyNewThread = new Thread(new ThreadStart(ThreadProc));

			MyNewThread.Start();
			MyNewThread.Join();
		}
		protected static void ThreadProc()
		{
			for (int i = 0; i > 100; i++)
			{
				Console.WriteLine(i);
			}
		}
	}
}
