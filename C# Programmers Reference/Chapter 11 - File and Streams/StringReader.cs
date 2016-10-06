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

namespace Client.Chapter_10___Interop_Services
{
	public class UsingStringReader
	{
		static void Main(string[] args)
		{
			// Create a string to read characters from.
			String MyString = "Hello World";

			// Size the array to hold all the characters of the string,
			// so that they are all accessible.
			char[] MyChar = new char[12];

			// Create a StringReader and attach it to the string.
			StringReader MyStringReader = new StringReader(MyString);

			// Read 5 characters from the array that holds the string, starting
			// from the first array member.
			MyStringReader.Read(MyChar, 0, 5);

			// Display the output.
			Console.WriteLine(MyChar);

			// Close the StringReader.
			MyStringReader.Close();
		}
	}

}
