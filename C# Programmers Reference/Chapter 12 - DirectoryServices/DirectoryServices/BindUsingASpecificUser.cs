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
	public class DirectoryBinding
	{
		public static int Main(string[] args)
		{
			DirectoryEntry MyDirectoryObject = new DirectoryEntry();
			
			MyDirectoryObject.Path = "LDAP://HMSRevenge/rootDSE";
			MyDirectoryObject.Username = @"Test\gregmcb";
			//IMPORTANT
			//In 1.2 you can set DirectoryEntry.Password but not Get
			MyDirectoryObject.Password = @"MyPassword";

			return 0;

		}
	}

}
