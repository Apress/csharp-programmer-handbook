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
	class Client
	{
		static void Main(string[] args)
		{
			SqlConnection cn = new SqlConnection(
			"Data Source=(local); Initial  Catalog = MyDatabase; User ID=sa;Password=");
			SqlCommand cmd = new SqlCommand("MyStoredProcedure", cn);
			cmd.CommandType = CommandType.StoredProcedure;
			SqlParameter param = new SqlParameter("@ReturnValue", SqlDbType.Int);
			cmd.Parameters.Add(param);
			cmd.Parameters.Add("MyFirstParameter", SqlDbType.Int);
			cmd.Parameters.Add("MySecondParameter", SqlDbType.Int).Direction =
			ParameterDirection.Output;
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			
		}
	}
}
