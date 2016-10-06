/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 * Version: 1
 */
using System;
using System.Data.Odbc;

namespace Client.Chapter_13___ADO.NET
{
	class CreatingConnectionToODBC
	{
		static void Main(string[] args)
		{
			OdbcConnection MyConnection = new OdbcConnection(
			"DRIVER={MySQL};SERVER=TESTSRV;DATABASE=MyDatabase;UID=root;PWD=\"\"");
			MyConnection.Open();			
		}
	}
}
