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
	public class DeletingFiles
	{
		static void Main(string[] args)
		{
			FileInfo MyFile = new FileInfo(@"c:\Projects\Testing.txt");

			MyFile.Create();
			MyFile.Delete();
		}
	}
}
