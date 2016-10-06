/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: August 6, 2003
 * Last Modified Date:
 * Version: 1
 */
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

//Add this functionality by using these methods
/*
 		private void Info_Click(object sender, System.EventArgs e)
		{
			XPSystrayBubble.XPBubble.INotification("Info Greg!");
		}

		private void OnLoad(object sender, System.EventArgs e)
		{
			XPSystrayBubble.XPBubble.AddIcon(this);
		}

		private void OnClose(object sender, System.EventArgs e)
		{
			XPSystrayBubble.XPBubble.RemoveIcon(this);
		}

		private void Warning_Click(object sender, System.EventArgs e)
		{
			XPSystrayBubble.XPBubble.INotification("Warning Greg!");
		}

		private void Error_Click(object sender, System.EventArgs e)
		{
			XPSystrayBubble.XPBubble.INotification("Error Greg!");
		}
*/

namespace Client.Chapter_20___Windows_Forms
{
	[StructLayout(LayoutKind.Sequential)] public struct NOTIFYICONDATA
	{
		public int cbSize;
		public IntPtr hwnd;
		public int uID;
		public int uFlags;
		public IntPtr uCallbackMessage;
		public IntPtr hIcon;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=128)]
		public string szTip;
		public int dwState;
		public int dwStateMask;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=256)]
		public string szInfo;
		public int uVersion;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst=64)]
		public string szInfoTitle;
		public int dwInfoFlags;
	}
	
	public class XPBubble
	{
		static public bool Result;
		public const int NIF_MESSAGE =		0x1;
		public const int NIF_ICON =			0x2;
		public const int NIF_TIP =			0x4;
		public const int NIF_STATE =		0x8;
		public const int NIF_INFO =			0x10;
		public const int NIF_GUID =			0x20;
		

		public const int NIM_ADD =			0x0;
		public const int NIM_MODIFY =		0x1;
		public const int NIM_DELETE =		0x2;
		public const int NIM_SETFOCUS =		0x3;
		public const int NIM_SETVERSION =	0x4;

		public const int NOTIFYICON_VERSION =	0x3;

		public const int NIS_HIDDEN =		0x1;
		public const int NIS_SHAREDICON =	0x2;

		
		
		public const int NIIF_NONE =		0x0;
		public const int NIIF_INFO =		0x1;		
		public const int NIIF_WARNING =		0x2;
		public const int NIIF_ERROR =		0x3;
		

		[DllImport("shell32.dll")]
		public static extern bool Shell_NotifyIcon(int dwMessage, ref NOTIFYICONDATA lpData); 

		public static NOTIFYICONDATA NIF = new NOTIFYICONDATA();

		public static void WNotification(string sMessage)
		{
			NIF.uFlags = NIF_INFO;
			NIF.uVersion = 2000;
			NIF.szInfoTitle = "Warning";
			NIF.szInfo = sMessage;
			NIF.dwInfoFlags = NIIF_WARNING;

			Result = Shell_NotifyIcon(NIM_MODIFY, ref NIF);
		}

		public static void ENotification(string sMessage)
		{
			NIF.uFlags = NIF_INFO;
			NIF.uVersion = 2000;
			NIF.szInfoTitle = "Error";
			NIF.szInfo = sMessage;
			NIF.dwInfoFlags = NIIF_ERROR;

			Result = Shell_NotifyIcon(NIM_MODIFY, ref NIF);
		}

		public static void INotification(string sMessage)
		{
			NIF.uFlags = NIF_INFO;
			NIF.uVersion = 2000;
			NIF.szInfoTitle = "Info";
			NIF.szInfo = sMessage;
			NIF.dwInfoFlags = NIIF_INFO;

			Result = Shell_NotifyIcon(NIM_MODIFY, ref NIF);
		}

		
		public static void RemoveIcon(System.Windows.Forms.Form X)
		{
			NIF.cbSize = Marshal.SizeOf(NIF);
			NIF.hwnd = X.Handle;
			NIF.uID = 1;

			Result = Shell_NotifyIcon(NIM_DELETE, ref NIF);
		}

		public static void AddIcon(System.Windows.Forms.Form X)
		{
			NIF.cbSize = Marshal.SizeOf(NIF);
			NIF.hwnd = X.Handle;
			NIF.uID = 1;
			NIF.uCallbackMessage = new IntPtr(0x500);
			NIF.uVersion = NOTIFYICON_VERSION;
			NIF.hIcon = X.Icon.Handle;


			Result = Shell_NotifyIcon(NIM_ADD, ref NIF);
		}
	}
}
