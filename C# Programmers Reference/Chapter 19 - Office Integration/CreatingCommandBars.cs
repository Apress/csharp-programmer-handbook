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
using System.Reflection;
using Word;
using Office = Microsoft.Office.Core;


namespace Client.Chapter_19___Office_Integration
{
	
	class Class1
	{
		[STAThread]
		static void Main(string[] args)
		{
			Office.CommandBarButton Button;
			Office.CommandBar CommandBar;
			object Missing = System.Reflection.Missing.Value;
			Office._CommandBarButtonEvents_ClickEventHandler ButtonHandler;
			Word.ApplicationClass MyWord = new Word.ApplicationClass();

			MyWord.Visible = true;
			CommandBar = MyWord.CommandBars.Add("MyCommandBar", Missing, Missing, Missing);
			Button = (Office.CommandBarButton)CommandBar.Controls.Add(Office.MsoControlType.msoControlButton, Missing, Missing, Missing, Missing);
			Button.Caption = "MyButton";
			Button.FaceId = 1845;
			ButtonHandler = new Office._CommandBarButtonEvents_ClickEventHandler(OnClick_Button);
			Button.Click += ButtonHandler;
			System.Windows.Forms.Application.Run();
		}
		private void OnClick_Button(Office.CommandBarButton ctrl, ref bool cancel)
		{
			MessageBox.Show("This Worked!!!");
		}
	}

}
