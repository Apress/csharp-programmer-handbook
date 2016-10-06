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
		static void Main(string[] args)
		{
			StringReader stream;
			XmlTextReader reader = null;

			stream = new StringReader("  XML File Text");

			// Load the XmlTextReader from the stream
			reader = new XmlTextReader(stream);
			while (reader.Read())
			{
				//TODO -
			}

			if (reader != null)
				reader.Close();
		}
	}
}
