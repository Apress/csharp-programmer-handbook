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
using System.IO;


namespace Client.Chapter_14___Networking_and_WWW
{
	class Class1
	{
		[STAThread]
		static void Main(string[] args)
		{
			WebRequest MyRequest = WebRequest.Create("http://www.MyWeb.com");
			WebResponse MyResponse = MyRequest.GetResponse();
			Stream MyStream = MyResponse.GetResponseStream();
			StreamReader MyReader = new StreamReader(MyStream);
			string MyWebLine;

			while ((MyWebLine = MyReader.ReadLine()) != null)
			{
				Console.WriteLine(MyWebLine);
			}

			MyStream.Close();
		}
	}
}
