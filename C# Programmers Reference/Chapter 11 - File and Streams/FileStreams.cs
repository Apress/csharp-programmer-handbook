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
	public class UsingFileStreams
	{
		static void Main(string[] args)
		{
			//Creates a file with read-write access that allows others to read
			FileStream MyFileStream1 = new FileStream(@"c:\Projects\Testing.txt", FileMode.Create);
			FileInfo MyFiles = new FileInfo(@"c:\Projects\Testing.txt");
			FileStream MyFileStream2 = MyFiles.OpenRead();

			//or any of the following
			MyFileStream2 = MyFiles.OpenWrite();
			MyFileStream2 = MyFiles.Open(FileMode.Append, FileAccess.Read, FileShare.None);
			MyFileStream2 = MyFiles.Create();

			//You can read file stream ona pe byte basis or as an array of bytes
			int MyBytes = MyFileStream1.ReadByte();

			//or
			int NumberOfBytes = 200;
			byte[] MyByteArray = new Byte[NumberOfBytes];
			int BytesRead = MyFileStream1.Read(MyByteArray, 0, NumberOfBytes);

			//Data can be written to FileStreams as well through bytes or arrays of //bytes
			byte MyWriteByte = 100;

			MyFileStream1.WriteByte(MyWriteByte);

			//or via an array
			int NumberOfBytesToWrite = 256;
			byte[] MyWriteByteArray = new Byte[NumberOfBytesToWrite];

			for (int i = 0; i < 256; i++)
			{
				MyWriteByteArray[i] = (byte)i;
				i++;
			}

			MyFileStream1.Write(MyWriteByteArray, 0, NumberOfBytesToWrite);
			MyFileStream1.Close();
			MyFileStream2.Close();
		}
	}

}
