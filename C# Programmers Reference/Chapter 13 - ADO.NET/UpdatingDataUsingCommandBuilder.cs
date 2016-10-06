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
	class UpdatingDataUsingCommondBuilder
	{
		static void Main(string[] args)
		{
			SqlConnection MyConnection = new SqlConnection(@"Data Source=(local); Initial Catalog = CaseManager; Integrated Security=true");
			SqlDataAdapter MyDataAdapter = new SqlDataAdapter("SELECT ID, Contact, Email FROM Test", MyConnection);
			DataSet MyDataSet = new DataSet();

			MyDataAdapter.Fill(MyDataSet);
			MyDataSet.Tables[0].Rows[0][0] = 55;

			SqlCommandBuilder MyCmd = new SqlCommandBuilder(MyDataAdapter);

			MyDataAdapter.Update(MyDataSet);
		}
	}
}
