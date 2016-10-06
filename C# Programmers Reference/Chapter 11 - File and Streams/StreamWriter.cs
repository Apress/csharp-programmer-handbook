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
	public class UsingStreamWriter
	{
		static void Main(string[] args)
		{
			//StreamWriter can only be use to write to files or other streams
			StreamWriter MyStreamWriter = new StreamWriter(@"c:\Projects\Testing.txt");

			//You can also use FileStream with StreamWriter to provide a greater degree of control
			//in how you open the file
			FileStream MyFileStream = new FileStream(@"c:\Projects\Testing.txt", FileMode.CreateNew, FileAccess.Write, FileShare.None);
			StreamWriter MyStreamWriter2 = new StreamWriter(MyFileStream);

			MyFileStream.Close();
			MyStreamWriter2.Close();

			//You can write sequentially to a file using this technique
			FileInfo MyFile = new FileInfo(@"c:\Projects\Testing.txt");
			StreamWriter MyStreamWriter3 = MyFile.CreateText();

			MyStreamWriter3.Close();

			//There are four overloaded ways to use StreamWriter.Write()
			//Writes a stream to a file
			string MyString = "Hello World";

			MyStreamWriter.Write(MyString);

			//Writes single characters to a stream
			char MyChar = 'A';

			MyStreamWriter.Write(MyChar);

			//Writes an Array of characters
			char[] MyCharArray = new char[100];

			for (int i = 0; i < 99; i++)
			{
				MyCharArray[i] = (char)i;
			}

			MyStreamWriter.Write(MyCharArray);

			//or you can write a portion of an array
			MyStreamWriter.Write(MyCharArray, 25, 30);
			MyStreamWriter.Close();
		}
	}

}
