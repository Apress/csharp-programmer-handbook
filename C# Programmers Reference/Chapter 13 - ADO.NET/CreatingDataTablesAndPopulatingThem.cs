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
	class CreatingDataTablesandPopulatingThem
	{
		static void Main(string[] args)
		{
			SqlConnection MyConnection = new SqlConnection(@"Data Source=(local); Initial Catalog = CaseManager; Integrated Security=true");
			SqlDataAdapter MyAdapter = new SqlDataAdapter("SELECT * FROM CaseInfo", MyConnection);
			DataSet MyDataSet = new DataSet();

			//Create a new DataTable
			DataTable MyTable2 = MyDataSet.Tables.Add("My2ndTable");

			//Adding Columns and Rows
			DataColumn myColumn = new DataColumn();

			myColumn.DataType = System.Type.GetType("System.Decimal");
			myColumn.AllowDBNull = false;
			myColumn.Caption = "Price";
			myColumn.ColumnName = "Price";
			myColumn.DefaultValue = 25;

			// Add the column to the table. 
			MyTable2.Columns.Add(myColumn);

			// Add 10 rows and set values. 
			DataRow myRow;

			for (int i = 0; i < 10; i++)
			{
				myRow = MyTable2.NewRow();
				myRow[0] = i + 1;

				// Be sure to add the new row to the DataRowCollection. 
				MyTable2.Rows.Add(myRow);
			}

			SqlCommandBuilder Builder = new SqlCommandBuilder(MyAdapter);

			MyAdapter.Update(MyDataSet, "My2ndTable");
		}
	}

}
