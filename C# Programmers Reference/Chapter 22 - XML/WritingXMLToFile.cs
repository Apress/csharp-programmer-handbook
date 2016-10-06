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
using System.Xml.Schema;


namespace Client.Chapter_22___XML
{
	class Test
	{
		static void Main(string[] args)
		{
			string document = "newbooks.xml";
			XmlTextWriter myXmlTextWriter = null;
			XmlTextReader myXmlTextReader = null;

			myXmlTextWriter = new XmlTextWriter(args[1], null);
			myXmlTextWriter.Formatting = Formatting.Indented;
			myXmlTextWriter.WriteStartDocument(false);
			myXmlTextWriter.WriteDocType("bookstore", null, "books.dtd", null);
			myXmlTextWriter.WriteComment("This file represents another fragment of a book store inventory database");
			myXmlTextWriter.WriteStartElement("bookstore");
			myXmlTextWriter.WriteStartElement("book", null);
			myXmlTextWriter.WriteAttributeString("genre", "autobiography");
			myXmlTextWriter.WriteAttributeString("publicationdate", "1979");
			myXmlTextWriter.WriteAttributeString("ISBN", "0-7356-0562-9");
			myXmlTextWriter.WriteElementString("title", null, "The Autobiography of Mark Twain");
			myXmlTextWriter.WriteStartElement("Author", null);
			myXmlTextWriter.WriteElementString("first-name", "Mark");
			myXmlTextWriter.WriteElementString("last-name", "Twain");
			myXmlTextWriter.WriteEndElement();
			myXmlTextWriter.WriteElementString("price", "7.99");
			myXmlTextWriter.WriteEndElement();
			myXmlTextWriter.WriteEndElement();

			//Write the XML to file and close the writer
			myXmlTextWriter.Flush();
			myXmlTextWriter.Close();
			if (myXmlTextWriter != null)
				myXmlTextWriter.Close();
		}
	}

}
