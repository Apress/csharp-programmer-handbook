/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 * Version: 1
 */
using System;
using Excel;
using System.Reflection;

namespace Client.Chapter_19___Office_Integration
{
	class TestClass
	{
		public static AppEvents_WorkbookBeforeCloseEventHandler Event_BeforeBookClose;
		public static DocEvents_ChangeEventHandler Event_ChangeEvent;
		static void Main(string[] args)
		{
			Application MyExcel = new ApplicationClass();
			Workbook MyWorkbook = MyExcel.Workbooks.Add(Missing.Value);

			MyWorkbook.Windows.get_Item(1).Caption = "Using Delegates";

			Worksheet MyWorksheet1 = (Worksheet)MyWorkbook.Worksheets.get_Item(1);
			Worksheet MyWorksheet2 = (Worksheet)MyWorkbook.Worksheets.get_Item(2);
			Worksheet MyWorksheet3 = (Worksheet)MyWorkbook.Worksheets.get_Item(3);

			MyWorksheet1.Activate();

			//Add Event Handler for the BeforeClose Event
			Event_BeforeBookClose = new AppEvents_WorkbookBeforeCloseEventHandler(BeforeBookClose);
			MyExcel.WorkbookBeforeClose += Event_BeforeBookClose;

			//Add Event Handler for the change Event
			Event_ChangeEvent = new DocEvents_ChangeEventHandler(CellChange);
			MyWorksheet1.Change += Event_ChangeEvent;
			MyWorksheet2.Change += Event_ChangeEvent;
			MyWorksheet3.Change += Event_ChangeEvent;
			MyExcel.Visible = true;
			MyExcel.UserControl = true;
		}
		private static void CellChange(Range Target)
		{
			//Gets called when you change a cell
		}
		private static void BeforeBookClose(Workbook MyWorkbook, ref bool Cancel)
		{
			//Gets called before closing a workbook
		}
	}

}
