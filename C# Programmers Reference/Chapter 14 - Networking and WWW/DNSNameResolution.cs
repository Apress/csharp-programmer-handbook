/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 * Version: 1
 */
using System;
using System.Net;

namespace Client.Chapter_14___Networking_and_WWW
{
	class Class1
	{
		[STAThread]
		static void Main(string[] args)
		{
			IPHostEntry MyHost = Dns.Resolve(args[0]);

			foreach (IPAddress MyIP in MyHost.AddressList)
			{
				Console.WriteLine(MyIP.Address);
			}
		}
	}
}
