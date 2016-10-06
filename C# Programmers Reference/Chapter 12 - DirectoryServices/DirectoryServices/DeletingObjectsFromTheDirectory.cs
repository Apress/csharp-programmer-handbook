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
	public class DeletingObjects
	{
		public static int Main(string[] args)
		{
			DirectoryEntry MyObject = new DirectoryEntry();
			MyObject.Path = "LDAP://HMSRevenge/OU=Users,DC=Test,DC=com";

			DirectoryEntries users = MyObject.Children;

			foreach(DirectoryEntry D in users)
			{
				if(D.Properties["email"].Value.ToString() == "gregmcb")
				{
					users.Remove(D);
				}
			}
			

			MyObject.CommitChanges();
			return 0;
		}
	}

}
