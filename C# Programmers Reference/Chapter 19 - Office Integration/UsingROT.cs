/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 * Version: 1
 */
using System;
using System.Runtime.InteropServices;
using Microsoft.Office.Core;


namespace Client.Chapter_19___Office_Integration
{
	class Class1
	{
		[STAThread]
		static void Main(string[] args)
		{
			Word.Application MyWord;

			MyWord = (Word.Application)Marshal.GetActiveObject("Word.Application");
			MyWord.Visible = true;
			MyWord.ShowStartupDialog = true;
			MyWord.ActiveDocument.PrintPreview();
		}
	}
}
