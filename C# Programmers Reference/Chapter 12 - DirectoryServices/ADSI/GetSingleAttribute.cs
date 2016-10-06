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
	
	public unsafe class GetSingleAttribute
	{
		public static int Main(string[] args)
		{
			string Path = "LDAP://dsaddom.nttest.microsoft.com/rootDSE";
			IADs pIADs = null;
			
			DirectoryEntry Entry = new DirectoryEntry(Path);
			pIADs = (IADs)Entry.NativeObject;

			string DefaultNamingContext = (string)pIADs.Get("defaultNamingContext");
			Console.WriteLine(DefaultNamingContext);
			
			//Required since GetEx returns an VARIANT array regardless of the number of items
			Array NamingContext = (Array)pIADs.GetEx("defaultNamingContext");
			for(int i = 0; i < NamingContext.GetLength(0); i++)
			{
				Console.WriteLine((string)NamingContext.GetValue(i));
			}

			return 0;
		}
	}
}
