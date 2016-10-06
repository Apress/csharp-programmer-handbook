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
	public class ModifyingExistingObjectAttributes
	{
		public static int Main(string[] args)
		{
			DirectoryEntry MyDirectoryObject = new DirectoryEntry();
			
			MyDirectoryObject.Path = "LDAP://HMSRevenge/CN=Greg MacBeth,OU=users,DC=Test,DC=com";
			MyDirectoryObject.Username = @"Test\gregmcb";
			MyDirectoryObject.Password = @"MyPassword";

			if(MyDirectoryObject.Properties[("company")].Value == "Old Company Name. inc.")
			{
				MyDirectoryObject.Properties[("company")][0] = "Microsoft Corporation";
			}

			MyDirectoryObject.CommitChanges();

			return 0;
		}
	}

}
