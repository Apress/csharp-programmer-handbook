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
using System.Net.Sockets;
using System.Text;


namespace Client.Chapter_14___Networking_and_WWW
{
	class CreatingSocketConnections
	{
		
		[STAThread]
		static void Main(string[] args)
		{
			TcpClient MyClient = new TcpClient();
			MyClient.Connect("localhost", 10000);
			NetworkStream MyNetStream = MyClient.GetStream();
				
			if(MyNetStream.CanWrite && MyNetStream.CanRead)
			{

				// Does a simple write.
			Byte[] sendBytes = Encoding.ASCII.GetBytes("Is anybody there");
			MyNetStream.Write(sendBytes, 0, sendBytes.Length);
      
				// Reads the NetworkStream into a byte buffer.
			byte[] bytes = new byte[MyClient.ReceiveBufferSize];
			MyNetStream.Read(bytes, 0, (int) MyClient.ReceiveBufferSize);
  
			// Returns the data received from the host to the console.
			string returndata = Encoding.ASCII.GetString(bytes);
			Console.WriteLine("This is what the host returned to you: " + returndata);

			}
			else if (!MyNetStream.CanRead)
			{
				Console.WriteLine("You can not write data to this stream");
				MyClient.Close();
			}
			else if (!MyNetStream.CanWrite)
			{             
				Console.WriteLine("You can not read data from this stream");
				MyClient.Close();
	}	}	}

}
