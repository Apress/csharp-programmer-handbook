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
	public class LoadXmlDocumentSample
	{
		private const String document = "books.xml";
		public static void Main()
		{
			LoadXmlDocumentSample myLoadXmlDocumentSample = new LoadXmlDocumentSample();

			myLoadXmlDocumentSample.Run(document);
		}
		public void Run(String args)
		{
			try
			{
				// Load the XML from file
				Console.WriteLine();
				Console.WriteLine("Loading file {0} ...", args);

				XmlDataDocument myXmlDocument = new XmlDataDocument();

				myXmlDocument.Load(args);
				Console.WriteLine("XmlDataDocument loaded with XML data successfully ...");

				// Display the XML document.
				myXmlDocument.Save(Console.Out);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception: {0}", e.ToString());
			}
		}
	} 
}
