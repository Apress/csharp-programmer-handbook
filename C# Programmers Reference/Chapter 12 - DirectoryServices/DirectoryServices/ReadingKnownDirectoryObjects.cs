/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 * Version: 1
 */
using System;
using System.DirectoryServices;

namespace Client.Chapter_12___DirectoryServices.DirectoryServices
{
	public class ReadingKnownDirectoryObjects
	{
		public static int Main(string[] args)
		{
			DirectoryEntry MyObject = new DirectoryEntry();
			MyObject.Path = "LDAP://HMSRevenge/OU=Users,DC=Test,DC=com";

			foreach(string MyValue in MyObject.Properties["email"])
				Console.WriteLine("Email" + " : " + MyValue);

			return 0;

		}
	}

}
