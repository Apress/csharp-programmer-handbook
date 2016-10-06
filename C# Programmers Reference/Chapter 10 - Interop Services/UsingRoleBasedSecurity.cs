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

[assembly: ApplicationName("SimpleRoles")] 
[assembly: ApplicationActivation(ActivationOption.Server)]
[assembly: ApplicationAccessControl(true, AccessChecksLevel=AccessChecksLevelOption.ApplicationComponent)] 
[assembly: SecurityRole("CompUsers", SetEveryoneAccess=true)] 
[assembly: SecurityRole("Marshaler", SetEveryoneAccess=true)] 

namespace Client.Chapter_10___Interop_Services
{
	public interface IMyArrayTests
	{
		int Test1Add(int Prop1, int Prop2);
		int Test2Add(int[] MyArray);
		void Test3Add(ref int[] MyArray);
	}

	[ComponentAccessControl]
	[SecureMethod]
	public class MyObj: ServicedComponent, IMyArrayTests
	{
		public MyObj(){	}
		
		[SecurityRole("CompUsers", true)]
		public int Test1Add(int Prop1, int Prop2)
		{
			return (Prop1 + Prop2);
		}

		[SecurityRole("CompUsers", true)]
		public int Test2Add(int[] MyArray)
		{
			return ((int)MyArray.GetValue(0) + (int)MyArray.GetValue(1));
		}

		[SecurityRole("CompUsers", true)]
		public void Test3Add(ref int[] MyArray)
		{
			MyArray.SetValue(((int)MyArray.GetValue(0) + (int)MyArray.GetValue(1)), 2);
			return;
		}
	}
}
