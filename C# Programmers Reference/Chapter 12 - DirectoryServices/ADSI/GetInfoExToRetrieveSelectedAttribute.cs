/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 * Version: 1
 */
using System;
using System.Runtime.InteropServices;
using System.DirectoryServices;

using ActiveDs;

namespace Client.Chapter_12___DirectoryServices.ADSI
{
	public unsafe class GetInfoExToRetrieveSelectedAttribute
	{
		public static int Main(string[] args)
		{
			string Path = "LDAP://dsaddom.nttest.microsoft.com/CN=Greg MacBeth,CN=Users,DC=dsaddom,DC=nttest,DC=MICROSOFT,DC=COM";
			string User = "dsaddom\\gregmcb";
			string Password = "gregmcb";
			string[] Properties = {"displayName", "sAMAccountName"};
									
			DirectoryEntry Entry = new DirectoryEntry(Path, User, Password);
			//This provides the same functionality as IADs.GetInfoEx
			Entry.RefreshCache(Properties);

			PropertyCollection MyAttributes = Entry.Properties;
			foreach (string MyAttributeName in MyAttributes.PropertyNames)
			{
				PropertyValueCollection MyAttributeValues = MyAttributes[MyAttributeName];
				foreach (string MyValue in MyAttributeValues)
				{
					Console.WriteLine(MyAttributeName + " = " + MyValue);
				}
			}
			return 0;
		}
	}
}
