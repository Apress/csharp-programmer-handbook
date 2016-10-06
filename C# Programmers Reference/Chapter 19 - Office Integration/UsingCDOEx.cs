/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 * Version: 1
 */
using System;
using CDO;
using ADODB;


namespace Client.Chapter_19___Office_Integration
{
	class TestClass
	{
		static void Main(string[] args)
		{
			Message MyMessage = new MessageClass();
			Configuration MyConfig = MyMessage.Configuration;
			Fields MyFields = MyConfig.Fields;

			MyFields[@"http://schemas.microsoft.com/cdo/configuration/sendusing"].Value = 2;
			MyFields[@"http://schemas.microsoft.com/cdo/configuration/smtpserverport"].Value = 25;
			MyFields[@"http://schemas.microsoft.com/cdo/configuration/smtpserver"].Value = "smarthost";
			MyFields.Update();
			MyMessage.Configuration = MyConfig;
			MyMessage.TextBody = "This is a test message";
			MyMessage.Subject = "Testing";
			MyMessage.From = "gregmcb@microsoft.com";
			MyMessage.To = "pmacbeth@comporium.com";
			MyMessage.Send();
		}
	}

}
