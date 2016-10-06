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
	class UsingDatasets
	{
		static void Main(string[] args)
		{
			SqlConnection MyConnection = new SqlConnection(@"Data Source=(local); Initial Catalog = CaseManager; Integrated Security=true");
			SqlDataAdapter MyAdapter = new SqlDataAdapter("SELECT * FROM CaseInfo", MyConnection);
			DataSet MyDataSet = new DataSet();

			MyAdapter.Fill(MyDataSet, "MyTable");
			MyDataSet.WriteXml(@"c:\MyDatSet.xml");
		}
	}
}
