/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 */
using System;
using System.Runtime.InteropServices;

namespace Client.Chapter_7___References__Pointers_and_Memory_Management
{
	class ReferencesandPointers
	{
		static void Main(string[] args)
		{
			UsePointers();
		}
		static unsafe public void UsePointers()
		{
			char * pMyArray = (char*)Marshal.AllocCoTaskMem(6);

			while (*pMyArray != '\0')
			{
				Console.WriteLine(*pMyArray);
				pMyArray++;
			}

			Marshal.FreeCoTaskMem((IntPtr)pMyArray);
		}
	}
}
