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
			//Port 389 is LDAP Port
			MyDirectoryObject.Path = "LDAP://HMSRevenge:389/OU=Users,DC=Test,DC=COM";
			MyDirectoryObject.Username = @"Test\gregmcb";
			MyDirectoryObject.Password = @"MyPassword";

			PropertyCollection MyAttributes = MyDirectoryObject.Properties;
			foreach(string MyAttributeName in MyAttributes.PropertyNames)
			{
				PropertyValueCollection MyAttributeValues = MyAttributes[MyAttributeName];
				foreach(string MyValue in MyAttributeValues)
				{
					Console.WriteLine(MyAttributeName + " = " + MyValue);
				}
			}

			return 0;
		}
	}

}
