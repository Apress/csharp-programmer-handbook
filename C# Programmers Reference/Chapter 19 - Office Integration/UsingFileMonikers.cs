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
using System.Windows.Forms;
using Excel;


namespace Client.Chapter_19___Office_Integration
{
	class Class1
	{
		[STAThread]
		static void Main(string[] args)
		{
			Excel.Workbook MyWorkBook;
			Excel.Worksheet MyWorkSheet;
			string FileName = @"C:\Cases\Test\bin\Debug\Mybook.xls";

			MyWorkBook = (Excel.Workbook)Marshal.BindToMoniker(FileName);
			MyWorkSheet = (Excel.Worksheet)MyWorkBook.ActiveSheet;
			System.Windows.Forms.Application.Run();
		}
	}
}
