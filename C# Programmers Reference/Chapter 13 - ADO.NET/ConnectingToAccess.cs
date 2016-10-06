/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 * Version: 1
 */
using System;
using System.Data.OleDb;

namespace Client.Chapter_13___ADO.NET
{
	class ConnectingToAccess
	{
		static void Main(string[] args)
		{
			OleDbConnection MyConnection = new OleDbConnection (
			@"Provider=Microsft.Jet.OLEDB.4.0; Data Source = c:\MyAccessDB.mdb");
			MyConnection.Open();			
		}
	}
}
