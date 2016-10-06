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
using System.Text;
using System.IO;


namespace Client.Chapter_14___Networking_and_WWW
{
	class MyWebClient
	{
		[STAThread]
		static void Main(string[] args)
		{
			WebClient MyClient = new WebClient();
			Stream MyStream = MyClient.OpenRead("http://www.MyWeb.com");
			StreamReader MyReader = new StreamReader(MyStream);

			Console.WriteLine(MyReader.ReadLine());
			MyStream.Close();
		}
	}
}
