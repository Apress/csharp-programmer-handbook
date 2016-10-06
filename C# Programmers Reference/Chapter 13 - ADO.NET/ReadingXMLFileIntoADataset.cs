/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 * Version: 1
 */
using System;
using System.IO;
using System.Data;


namespace Client.Chapter_13___ADO.NET
{
	class ReadingAnXMLFileIntoADataset
	{
		static void Main(string[] args)
		{
			string MyXMLDoc = @"<?xml version=’1.0’>?
							<title> MyExample</title>";
			StringReader MyStringReader = new StringReader(MyXMLDoc);
			DataSet MyDataSet = new DataSet();

			MyDataSet.ReadXml(MyStringReader);
		}
	}
}
