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
	class CreatingOfficeApplications
	{
		[STAThread]
		static void Main(string[] args)
		{
			Word.ApplicationClass MyWord = new Word.ApplicationClass();

			MyWord.Visible = true;
			System.Windows.Forms.Application.Run();
		}
	}
}
