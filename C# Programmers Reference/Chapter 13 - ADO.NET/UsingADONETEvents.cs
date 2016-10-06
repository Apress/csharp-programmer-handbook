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
	class UsingADONETEvents
	{
		static void Main(string[] args)
		{
			SqlConnection MyConnection = new SqlConnection(@"Data Source=(local); Initial Catalog = CaseManager; Integrated Security=true");

			MyConnection.StateChange += new StateChangeEventHandler(OnStateChange);
			MyConnection.Open(); //Trigger Open Event
			MyConnection.Close();
		}
		public static void OnStateChange(object sender, System.Data.StateChangeEventArgs e)
		{
			Console.WriteLine("Connection State Chnaged: {0}", ((SqlConnection)sender).State);
		}
	}
}
