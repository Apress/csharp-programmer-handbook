/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 * Version: 1
 */

using System;
using System.EnterpriseServices;

namespace Client.Chapter_10___Interop_Services
{
	public interface IObjCreator
	{
		void HelloWorld();
	}
	public class CObjCreator: ServicedComponent, IObjCreator
	{
		
		public void HelloWorld()
		{
			//Do Something
		}
	}
}
