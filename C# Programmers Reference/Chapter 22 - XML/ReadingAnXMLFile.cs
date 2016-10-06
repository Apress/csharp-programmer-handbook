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
using System.Xml;


namespace Client.Chapter_22___XML
{
	class Test
	{
		private const string doc = "Test.xml";
		static void Main(string[] args)
		{
			XmlTextReader reader = null;

			// Load the file with an XmlTextReader
			reader = new XmlTextReader(doc);

			// Read the File
			while (reader.Read())
			{
				//TODO - 
			}

			if (reader != null)
				reader.Close();
		}
	}
}
