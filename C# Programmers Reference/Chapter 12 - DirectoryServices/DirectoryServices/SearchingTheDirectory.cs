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
	public class CloseClass
	{
		
		static void Main(string[] args)
		{
			try
			{
				DirectoryEntry oRoot = new DirectoryEntry("LDAP://RootDSE");
				string searchOU = (string)oRoot.Properties["defaultnamingcontext"].Value;
				DirectoryEntry de = new DirectoryEntry("LDAP://CN=Users," + searchOU); 
				Console.WriteLine(oRoot.Name);
				oRoot.Close();
					
				DirectorySearcher search = new DirectorySearcher(de);
				search.Filter = "(CN=Administrator)";
				search.PropertiesToLoad.Add("distinguishedName");
				SearchResultCollection results = search.FindAll();
				
				string strRet="Not Found";
				foreach(SearchResult result in results)
				{
					DirectoryEntry data = result.GetDirectoryEntry();
					strRet = (string)data.Properties["distinguishedName"].Value;
					Console.WriteLine(strRet);
					data.Close();
				}
				de.Close();
				results.Dispose(); //Required or you may leak TCP Connections				
				}
			catch(Exception e)
			{
				Console.WriteLine( e.Message);
			}

			

		}
	}
}
