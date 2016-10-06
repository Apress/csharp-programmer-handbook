/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 */
using System;

namespace Client.Chapter_6___Strings
{
	class CreatingStrings
	{
		static void Main(string[] args)
		{
			char MyChar = 'A';

			MyChar = (char)65;

			char[] MyChar2 = {'H','e','l','l','o','\0'};

			char[] MyChar3 = new char[5];

			MyChar3[0] = 'H';
			MyChar3[1] = 'e';
			MyChar3[2] = 'l';
			MyChar3[3] = 'l';
			MyChar3[4] = 'o';
			MyChar3[5] = '\0';
		}
	}
}
