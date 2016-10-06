/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 */
using System;

namespace Client.Chapter_3___Structs__Enums__Arrays_and_Classes
{
	public struct MyStruct
	{
		public int MyInt;
		public long MyLong;
		public string MyString;
	}
	class Structs
	{
		static void Main(string[] args)
		{
			MyStruct TheStruct;

			TheStruct.MyInt = 0;
			TheStruct.MyLong = 0;
			TheStruct.MyString = "Hello World";
		}
	}
}
