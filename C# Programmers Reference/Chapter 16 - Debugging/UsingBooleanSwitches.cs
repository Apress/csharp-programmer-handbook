/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 * Version: 1
 */
using System;
using System.IO;
using System.Diagnostics;


namespace Client.Chapter_16___Debugging
{
	class UsingBooleanSwitch
	{
		static BooleanSwitch MySwitch = new BooleanSwitch("MyData", "MyModule");
		[STAThread]
		static void Main(string[] args)
		{
			MySwitch.Enabled = true;
			if (MySwitch.Enabled)
				Console.WriteLine("Error happened!");
		}
	}
}
