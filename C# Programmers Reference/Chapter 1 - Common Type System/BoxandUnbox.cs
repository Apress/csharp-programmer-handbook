/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 * Version: 1
 */
using System;

namespace Client.Chapter_1___Common_Type_System
{
	class BoxandUnbox
	{
		static void Main(string[] args)
		{
			long MyLong = 1005;
			object MyObject = MyLong;
			long MyLong2 = (long)MyObject;
		}
	}
}
