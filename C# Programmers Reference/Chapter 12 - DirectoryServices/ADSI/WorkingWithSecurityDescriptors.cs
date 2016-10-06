/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 * Version: 1
 */
using System;
using System.Collections;
using System.DirectoryServices;
using ActiveDs;

namespace Client.Chapter_12___DirectoryServices.ADSI
{
	
	public class WorkingWithSecurityDescriptors
	{
		static void Main(string[] args)
		{
			string Path = "LDAP://dsaddom.nttest.microsoft.com/CN=Greg MacBeth,CN=Users,DC=dsaddom,DC=nttest,DC=MICROSOFT,DC=COM";
			string User = "dsaddom\\gregmcb";
			string Password = "gregmcb";
			DirectoryEntry Entry = new DirectoryEntry(Path, User, Password);
			AccessControlEntry newAce = new AccessControlEntryClass();


			//Read the SecurityDescriptor
			SecurityDescriptor sd = (SecurityDescriptor)Entry.Properties["ntSecurityDescriptor"].Value;
			AccessControlList acl = (AccessControlList)sd.DiscretionaryAcl;

			foreach (AccessControlEntry ace in (IEnumerable)acl)
			{
				Console.WriteLine("Trustee: {0}", ace.Trustee);
				Console.WriteLine("AccessMask: {0}", ace.AccessMask);
				Console.WriteLine("Access Type: {0}", ace.AceType);
			}

			//Modify the SecurityDescriptor
			newAce.Trustee = "Jim";
			newAce.AccessMask = -1;
			newAce.AceType = 0;
			acl.AddAce(newAce);
			sd.DiscretionaryAcl = acl;
			Entry.Properties["ntSecurityDescriptor"].Value = sd;
			Entry.CommitChanges();

		}
	}
}
