/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 * Version: 1
 */
using System;
using System.Diagnostics;

namespace Client.Chapter_16___Debugging
{
	class PoorMansProfiler
	{
		[STAThread]
		static void Main(string[] args)
		{
			DateTime Start = DateTime.Now;
			DateTime End = DateTime.Now;
			TimeSpan CallTime = End - Start;

			Console.WriteLine("Call Time(MS): " + CallTime.Milliseconds.ToString());
		}
	}
}
