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
	public class AddingObjectsToTheDirectory
	{
		public static int Main(string[] args)
		{
			DirectoryEntry MyObject = new DirectoryEntry();
			MyObject.Path = "LDAP://HMSRevenge/OU=Users,DC=Test,DC=com";

			DirectoryEntries users = MyObject.Children;

			DirectoryEntry NewUser = users.Add("Greg MacBeth", "user");
			NewUser.Properties["company"].Add("Microsoft Corporation");
			NewUser.Properties["employeeID"].Add("1001");
			NewUser.Properties["userPassword"].Add("Password");

			NewUser.CommitChanges();

			return 0;
		}
	}

}
