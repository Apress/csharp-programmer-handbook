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
	
	public unsafe class GetMultiValuedAttribute
	{
		public static int Main(string[] args)
		{
			string Path = "LDAP://dsaddom.nttest.microsoft.com/rootDSE";
			IADs pIADs = null;
			
			DirectoryEntry Entry = new DirectoryEntry(Path);
			pIADs = (IADs)Entry.NativeObject;

			Array NamingContexts = (Array)pIADs.Get("namingContexts");
			for(int i = 0; i < NamingContexts.GetLength(0); i++)
			{
				Console.WriteLine((string)NamingContexts.GetValue(i));
			}
			
			Array Contexts = (Array)pIADs.GetEx("namingContexts");
			for(int i = 0; i < NamingContexts.GetLength(0); i++)
			{
				Console.WriteLine((string)Contexts.GetValue(i));
			}

			return 0;
		}
	}
}
