/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 * Version: 1
 */
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Word;

namespace Client.Chapter_19___Office_Integration
{
	class Class1
	{
		[STAThread]
		static void Main(string[] args)
		{
			Word._Application MyWord = (Word._Application)Marshal.GetActiveObject("Word.Application");

			MyWord.PrintPreview = true;
			System.Windows.Forms.Application.Run();
		}
	}
}
