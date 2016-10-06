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
	class DeletingDataUsingCommandBuilder
	{
		static void Main(string[] args)
		{
			SqlConnection MyConnection = new SqlConnection(@"Data Source=(local); Initial Catalog = CaseManager; Integrated Security=true");
			SqlDataAdapter MyDataAdapter = new SqlDataAdapter("SELECT * FROM Test", MyConnection);
			SqlCommandBuilder MyCmd = new SqlCommandBuilder(MyDataAdapter);
			DataSet MyDataSet = new DataSet();

			MyDataAdapter.Fill(MyDataSet);

			DataColumn[] MyKey = new DataColumn[1];

			MyKey[0] = MyDataSet.Tables[0].Columns[0];
			MyDataSet.Tables[0].PrimaryKey = MyKey;

			DataRow FindMyRow = MyDataSet.Tables[0].Rows.Find(1);

			FindMyRow.Delete();
			MyDataAdapter.Update(MyDataSet);
		}
	}
}
