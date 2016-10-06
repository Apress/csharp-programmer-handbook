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
	public class DirectoryObject
	{
		static void Main(string[] args)
		{
			DirectoryInfo MyRoot = new DirectoryInfo(@"c:\projects");
			DirectoryInfo[] MySub;
			DirectoryInfo TheFolder = null;
			FileInfo[] MyFiles;
			FileInfo TheFile = null;
			FileStream MyStream;

			MyRoot.CreateSubdirectory("MyFolder");
			MySub = MyRoot.GetDirectories();
			foreach (DirectoryInfo D in MySub)
			{
				if (D.Name == "MyFolder")
					TheFolder = D;
			}

			MyFiles = TheFolder.GetFiles();
			foreach (FileInfo F in MyFiles)
			{
				if (F.Name == "Testing.txt")
				{
					TheFile = F;
					MyStream = TheFile.Open(FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);

					int i = 0;
					byte b = 0;

					while (i != 000)
					{
						MyStream.WriteByte(b);
						i++;
						b++;
					}
				}
			}

			TheFile.Delete();
			TheFolder.Delete();
		}
	}
}
