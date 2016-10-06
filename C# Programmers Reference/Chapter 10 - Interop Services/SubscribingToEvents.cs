/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 * Version: 1
 */
using System;
using SHDocVw;

namespace Client.Chapter_10___Interop_Services
{
	class BrowserListener
	{
		private InternetExplorer ie;
		public BrowserListener()
		{
			ie = new InternetExplorerClass();
			ie.DocumentComplete += new DWebBrowserEvents2_DocumentCompleteEventHandler(DocComplete);
			ie.TitleChange += new DWebBrowserEvents2_TitleChangeEventHandler(TitleMod);
			ie.Visible = true;
			ie.GoHome();
		}
		public void DocComplete(object pDisp, ref object URL)
		{
			Console.WriteLine("Document Complete: " + URL);
		}
		public void TitleMod(string Text)
		{
			Console.WriteLine("Title Change: " + Text);
		}
		[STAThread]
		static void Main(string[] args)
		{
			BrowserListener listener = new BrowserListener();

			Console.WriteLine("*** Press Enter to quit ***");
			Console.Read();
		}
	}
}
