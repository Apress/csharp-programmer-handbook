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
	public class Win32
	{
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern int MessageBox(int hWnd, String text, String caption, uint type);
	}
	class Class1
	{
		[STAThread]
		static void Main(string[] args)
		{
			Win32.MessageBox(0, "Hello World", "MyBox", 1);
		}
	}
}
