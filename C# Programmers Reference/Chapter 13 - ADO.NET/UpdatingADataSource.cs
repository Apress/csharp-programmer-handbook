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
using System.Data.OleDb;

namespace Client.Chapter_13___ADO.NET
{
	class UpdatingADataSource
	{
		static void Main(string[] args)
		{
			OleDbConnection MyConnection = new OleDbConnection(@"Provider=Microsft.Jet.OLEDB.4.0; Data Source = c:\MyAccessDB.mdb");
			OleDbDataAdapter MyAdapter = new OleDbDataAdapter("SELECT Column1, Column2, Column3 FROM MyTable", MyConnection);
			DataSet MyDataSet = new DataSet();

			MyAdapter.Fill(MyDataSet, "MyTable");
			MyDataSet.Tables[0].Rows[3]["Column3"] = "Test";

			OleDbCommandBuilder MyBuilder = new OleDbCommandBuilder(MyAdapter);

			MyAdapter.Update(MyDataSet.Tables[0]);
		}
	}
}
