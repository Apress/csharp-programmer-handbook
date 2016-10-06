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
	class Class1
	{
		[STAThread]
		static void Main(string[] args)
		{
			Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));

			Trace.WriteLine("My Trace to the console");
			
        }
	}
}
