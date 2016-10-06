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
using SpeechLib;


namespace Client.Chapter_10___Interop_Services
{
	class EarlyBinding
	{
		[STAThread]
		static void Main(string[] args)
		{
			SpVoiceClass X = new SpVoiceClass();
			X.Speak("Hello World", 0);

		}
	}
}
