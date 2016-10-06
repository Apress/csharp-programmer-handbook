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
	class UsingMultiTabledDatasets
	{
		static void Main(string[] args)
		{
			OleDbConnection MyConnection = new OleDbConnection(@"Provider=Microsft.Jet.OLEDB.4.0; Data Source = c:\MyAccessDB.mdb");
			OleDbDataAdapter MyAdapter = new OleDbDataAdapter("SELECT Column1, Column2, Column3 FROM MyTable", MyConnection);
			DataSet MyDataSet = new DataSet();

			MyAdapter.Fill(MyDataSet, "MyTable");
			foreach (DataTable MyTable in MyDataSet.Tables)
			{
				foreach (DataColumn MyColumn in MyTable.Columns)
				{
					foreach (DataRow MyRow in MyTable.Rows)
					{
					}
				}
			}
		}
	}
}
