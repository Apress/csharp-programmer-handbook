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
using System.Net.Sockets;

namespace Client.Chapter_14___Networking_and_WWW
{
	class ListeningForSockets
	{
		[STAThread]
		static void Main(string[] args)
		{
			int PortNumber = 10000;
			TcpListener MyListener = new TcpListener(PortNumber);

			MyListener.Start();

			//Console.WriteLine("Waiting For Connection “);
			TcpClient MyClient = MyListener.AcceptTcpClient();

			Console.WriteLine("Connection Accepted");

			NetworkStream MyNetStream = MyClient.GetStream();
			String Response = "Connection Has been accepted";
			Byte[] SendTheseBytes = Encoding.ASCII.GetBytes(Response);

			MyNetStream.Write(SendTheseBytes, 0, SendTheseBytes.Length);
			MyClient.Close();
			MyListener.Stop();
		}
	}

}
