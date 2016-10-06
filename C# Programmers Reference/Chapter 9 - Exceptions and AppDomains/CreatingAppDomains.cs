/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 */
using System;
using System.Runtime.Remoting;

namespace Client.Chapter_9___Exceptions_and_AppDomains
{
	class MyServer
	{
		[MTAThread]
		static void Main(string[] args)
		{
			AppDomain Domain2 = AppDomain.CreateDomain("AppDomainB");
			RemoteObj MyRemoteObj = (RemoteObj)Domain2.CreateInstanceAndUnwrap("Server", "Server.RemoteObj");

			MyRemoteObj.Test();
			Console.WriteLine("Finshed");
		}
	}
	public class RemoteObj: MarshalByRefObject
	{
		public RemoteObj()
		{
			Console.WriteLine("CTOR Called");
		}
		public void Test()
		{
			Console.WriteLine("RemObj Test Method Called");
		}
	}
}
