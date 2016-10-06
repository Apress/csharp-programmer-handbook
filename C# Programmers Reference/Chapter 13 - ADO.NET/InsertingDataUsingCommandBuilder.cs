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
	class InsertingDataUsingCommandBuilder
	{
		static void Main(string[] args)
		{
			SqlConnection MyConnection = new SqlConnection(@"Data Source=(local); Initial Catalog = CaseManager; Integrated Security=true");
			SqlDataAdapter MyDataAdapter = new SqlDataAdapter("SELECT ID, Contact, Email FROM Test", MyConnection);
			SqlCommandBuilder MyCmd = new SqlCommandBuilder(MyDataAdapter);
			DataSet MyDataSet = new DataSet();

			MyDataAdapter.Fill(MyDataSet);

			DataRow MyRow = MyDataSet.Tables[0].NewRow();

			MyRow["ID"] = 200;
			MyRow["Contact"] = "Greg";
			MyRow["Email"] = "MacBeth";
			MyDataSet.Tables[0].Rows.Add(MyRow);
			MyDataAdapter.Update(MyDataSet);
		}
	}
}
