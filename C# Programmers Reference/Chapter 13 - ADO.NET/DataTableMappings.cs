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
using System.Data.Common;
using System.Data.SqlClient;

namespace Client.Chapter_13___ADO.NET
{
	class UsingDataTableMappings
	{
		static void Main(string[] args)
		{
			SqlConnection SConn = new SqlConnection("Data Source=(local); Initial Catalog = CaseManager; Integrated Security=true");
			SqlDataAdapter da = new SqlDataAdapter("SELECT ID, Contact, Email FROM CaseInfo", SConn);
			DataSet ds = new DataSet();
			DataTableMapping custMap = da.TableMappings.Add("CaseInfo", "MyDatabase");
			custMap.ColumnMappings.Add("ID", "CaseNumber");
			custMap.ColumnMappings.Add("Contact", "MyContact");
			custMap.ColumnMappings.Add("Email", "Email Address");
			da.Fill(ds);
		}
	}
}
