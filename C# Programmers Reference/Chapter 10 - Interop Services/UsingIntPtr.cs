/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 * Version: 1
 */
using System;
using System.Runtime.InteropServices;

namespace Client.Chapter_10___Interop_Services
{
	public class TestClass
	{
		[STAThread]
		static void Main(string[] args)
		{
			IntPtr ptr = IntPtr.Zero;

			ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(int)));
			Marshal.FreeHGlobal(ptr);
		}
	}
}
