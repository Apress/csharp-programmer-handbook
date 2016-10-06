/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 */
using System;
using System.IO;

namespace Client.Chapter_9___Exceptions_and_AppDomains
{
	class MyMainClass
	{
		delegate int MyDelegate(string s);
		static void Main(string[] args)
		{
			StreamWriter MyStream = null;
			string MyString = "Hello World";

			try
			{
				MyStream = File.CreateText("MyFile.txt");
				MyStream.Write(MyString);
			}
			catch (IOException e)
			{
				Console.WriteLine(e);
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
			finally
			{
				if (MyStream != null)
					MyStream.Close();
			}
		}
	}
	public class MyFile
	{
		public StreamWriter WriteText(string s)
		{
			if (!Valid(s))
				throw new IOException("Can’t Write String");
			else
				return new StreamWriter("c:\\test.txt");
		}
		public bool Valid(string s)
		{
			return false;
		}
	}
}
