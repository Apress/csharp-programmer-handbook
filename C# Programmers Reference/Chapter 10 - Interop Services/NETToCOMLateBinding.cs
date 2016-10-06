/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 * Version: 1
 */
using System;
using System.Reflection;


namespace Client.Chapter_10___Interop_Services
{
	class LateBinding
	{
		[STAThread]
		static void Main(string[] args)
		{
			//Late Binding Example
			Type t = Type.GetTypeFromProgID("SAPI.SpVoice");
			Object o = Activator.CreateInstance(t);
			Object[] a = new Object[2];

			a[0] = "Hello World";
			a[1] = 0;
			t.InvokeMember("Speak", BindingFlags.InvokeMethod, null, o, a);
		}
	}
}
