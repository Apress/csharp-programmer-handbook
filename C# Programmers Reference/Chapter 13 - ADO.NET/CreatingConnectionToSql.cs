/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 * Version: 1
 */
using System;
using System.Data.SqlClient;

namespace Client.Chapter_13___ADO.NET
{
	class CreatingSQLConnections
	{
		static void Main(string[] args)
		{
			SqlConnection MyConnection = new SqlConnection("Data Source=(local); Initial  Catalog = MyDatabase; User ID=sa;Password=");

			MyConnection.Open();
		}
	}
}
