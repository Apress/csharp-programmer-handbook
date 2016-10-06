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

namespace LDAP.ADSI
{
	
	public unsafe class SimpleADSICall
	{
		public static int Main(string[] args)
		{
			string Path = "LDAP://dsaddom.nttest.microsoft.com/rootDSE";
			IADs pIADs = null;
			
			DirectoryEntry Entry = new DirectoryEntry(Path);
			pIADs = (IADs)Entry.NativeObject;
			

			return 0;
		}
	}
}
