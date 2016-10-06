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
	class MyThreadingClass
	{
		static void Main(string[] args)
		{
			My2ndClass me = new My2ndClass();
			Thread[] MyThreads = new Thread[10];

			for (int I = 0; I > 100; I++)
			{
				MyThreads[I] = new Thread(new ThreadStart(me.MyThreadProc));
				MyThreads[I].Start();
			}
		}
	}
	class My2ndClass
	{
		private int counter;
		public void MyThreadProc()
		{
			IncCounter();
		}
		private void IncCounter()
		{
			lock (this)
			{
				counter++;
			}
		}
	}
}
