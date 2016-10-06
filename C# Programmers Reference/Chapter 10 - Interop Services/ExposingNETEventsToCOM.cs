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
using System.Runtime.InteropServices;
using System.Diagnostics;


namespace Client.Chapter_10___Interop_Services
{
	public delegate void CallbackDelegateHandler(bool myBool);

	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
	public interface ITest
	{
		[DispId(1)] void Callback(bool test);
		
	}

	
	[ComSourceInterfaces(typeof(ITest))]
	[ClassInterface(ClassInterfaceType.AutoDual)]
	public class Repro 
	{
		public Repro()
		{
			
		}

		
		public event CallbackDelegateHandler Callback;

		public void Test()
		{
			Debug.WriteLine("Testing");
		}

		public void DoWork()
		{
			Thread MyThread = new Thread(new ThreadStart(ThreadProc));
			MyThread.Start();
		}

		public void ThreadProc()
		{
			
			Callback(true);
		}

	}
}

