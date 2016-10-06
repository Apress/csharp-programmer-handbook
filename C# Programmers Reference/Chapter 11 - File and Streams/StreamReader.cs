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

namespace Client.Chapter_11___File_and_Streams
{
	public class StreamReaderAndWriter
	{
		static void Main(string[] args)
		{
			StreamReader MyStreamReader = new StreamReader(@"c:\Projects\Testing.txt");

			//If you need to control share permissions when creating a file you
			//use FileStream with StreamReader
			FileStream MyFileStream = new FileStream(@"c:\Projects\Testing.txt", FileMode.Open, FileAccess.Read, FileShare.None);
			StreamReader MyStreamReader2 = new StreamReader(MyFileStream);

			MyFileStream.Close();
			MyStreamReader2.Close();

			//The easiest way to Read a stream is to use the ReadLine method.
			//This method reads until it gets to the end of a line, but ...
			//it does not copy the carriage return line feed /n/r.
			string MyStringReader = MyStreamReader.ReadLine();

			//You can also read the whole file by using the following
			string MyStringReadToEOF = MyStreamReader.ReadToEnd();

			//The other route is to read one character at a time
			int[] MyArrayOfCharacters = new int[100];

			for (int i = 0; i < 99; i++)
			{
				MyArrayOfCharacters[i] = MyStreamReader.Read();
			}

			MyStreamReader.Close();
		}
	}

}
