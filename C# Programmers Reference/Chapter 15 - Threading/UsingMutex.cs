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
	class ThreadingClassMutex
	{
		public static Thread ThreadOne = new Thread(new ThreadStart(MutexExample));
		public static ArrayList MyList = new ArrayList();
		private static Mutex MyMutex = new Mutex(false, "MyMutex");
		public ThreadingClassMutex()
		{
			MyList.Add("Test1");
			MyList.Add("Test2");
		}
		static void Main(string[] args)
		{
			ThreadOne.Start();
		}
		protected static void MutexExample()
		{
			MyMutex.WaitOne();
			MyList.Add("Test3");
			MyMutex.ReleaseMutex();
		}
	}

}
