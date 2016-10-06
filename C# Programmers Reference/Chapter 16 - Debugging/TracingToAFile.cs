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
	class TracingToAFile
	{
		[STAThread]
		static void Main(string[] args)
		{
			FileStream Log = new FileStream("Log.txt", FileMode.OpenOrCreate);

			Trace.Listeners.Add(new TextWriterTraceListener(Log));
			Trace.WriteLine("My Trace String To Log File");
			Trace.Flush();
			Log.Close();
		}
	}
}
