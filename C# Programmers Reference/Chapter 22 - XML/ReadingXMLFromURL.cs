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
			string localURL = "http:\\Test\\Test.xml";
			XmlTextReader myXmlURLreader = null;
			myXmlURLreader = new XmlTextReader (localURL);

			while (myXmlURLreader.Read())
			{
				//TODO - 

			}
			if (myXmlURLreader != null)
				myXmlURLreader.Close();

		}
	}
}
