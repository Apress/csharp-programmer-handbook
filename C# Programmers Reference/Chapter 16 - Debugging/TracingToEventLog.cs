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
	class TracingToEventLog
	{
		[STAThread]
		static void Main(string[] args)
		{
			//You can change the listener with the following code
			EventLogTraceListener EventListener = new EventLogTraceListener("MyApp");

			Trace.Listeners.Add(EventListener);
			
			Trace.WriteLine("My Trace String To Console");

			
        }
	}

}
