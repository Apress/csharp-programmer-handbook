/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 * Version: 1
 */
using System;
using System.Data;
using System.Data.SqlClient;

namespace Client.Chapter_13___ADO.NET
{
	class UsingADataReader
	{
		static void Main(string[] args)
		{
			SqlConnection MyConnection = new SqlConnection(@"Data Source=(local); Initial Catalog = CaseManager; Integrated Security=true");

			MyConnection.Open();

			SqlCommand MyCommand = new SqlCommand("SELECT * FROM CaseInfo", MyConnection);
			SqlDataReader MyDataReader = MyCommand.ExecuteReader(CommandBehavior.CloseConnection);

			while (MyDataReader.Read())
			{
				Console.WriteLine(MyDataReader[0] + " " + MyDataReader[1]);
			}

			MyConnection.Close();
		}
	}
}
