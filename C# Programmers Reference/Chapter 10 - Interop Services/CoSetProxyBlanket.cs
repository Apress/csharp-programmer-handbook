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
using System.Reflection;

namespace Client.Chapter_10___Interop_Services
{
	public struct COAUTHIDENTITY
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string User;
		public uint UserLength;
		[MarshalAs(UnmanagedType.LPWStr)]
		public string Domain;
		public uint DomainLength;
		[MarshalAs(UnmanagedType.LPWStr)]
		public string Password;
		public uint PasswordLength;
		public uint Flags;
	};
	class Class1
	{
		// various constants
		const uint EOAC_NONE = 0;
		const uint SEC_WINNT_AUTH_IDENTITY_UNICODE = 2;
		const uint RPC_C_AUTHN_WINNT = 10;
		const uint RPC_C_AUTHZ_NONE = 0;
		const uint RPC_C_AUTHN_LEVEL_DEFAULT = 0;
		const uint RPC_C_IMP_LEVEL_IMPERSONATE = 3;
		[DllImport("Ole32.dll", CharSet = CharSet.Auto)]
		public static extern int CoSetProxyBlanket(IntPtr pProxy, uint dwAuthnSvc, uint dwAuthzSvc, uint pServerPrincName, uint dwAuthLevel, uint dwImpLevel, IntPtr pAuthInfo, uint dwCapabilities);
		[STAThread]
		static void Main(string[] args)
		{
         int hr;

         Guid CLSID = new Guid("1ACD2158-6E0E-48B6-A01C-ACF1CAC48580");
         string machineName = "MyPCName";
         System.Type typeInfo = Type.GetTypeFromCLSID(CLSID,machineName,true);
         Console.WriteLine("Type.GetTypeFromCLSID successful");
         Console.ReadLine();
		
			object objDCOM = Activator.CreateInstance(typeInfo);
         Console.WriteLine("Activator.CreateInstance successful");
         Console.ReadLine();

         COAUTHIDENTITY Auth = new COAUTHIDENTITY();
         IntPtr pAuth = Marshal.AllocCoTaskMem(28);
         Auth.User = "myusername";
         Auth.UserLength = (uint)Auth.User.Length;
         Auth.Domain = "mydomain";
         Auth.DomainLength = (uint)Auth.Domain.Length;
         Auth.Password = "mypassword";
         Auth.PasswordLength = (uint)Auth.Password.Length;
         Auth.Flags = SEC_WINNT_AUTH_IDENTITY_UNICODE;
         Marshal.StructureToPtr(Auth, pAuth, false);
         
         hr = CoSetProxyBlanket(Marshal.GetIUnknownForObject(objDCOM), // pProxy
            RPC_C_AUTHN_WINNT, // dwAuthnSvc
            RPC_C_AUTHZ_NONE, // dwAuthzSvc
            0, // pServerPrincName
            RPC_C_AUTHN_LEVEL_DEFAULT, // dwAuthnLevel
            RPC_C_IMP_LEVEL_IMPERSONATE, // dwImpLevel
            pAuth, // pAuthInfo
            EOAC_NONE); // dwCapabilities

         Console.WriteLine("CoSetProxyBlanket for IUnknown returned " + hr);
         if (hr != 0)
            return;

         hr = CoSetProxyBlanket(Marshal.GetIDispatchForObject(objDCOM), // pProxy
            RPC_C_AUTHN_WINNT, // dwAuthnSvc
            RPC_C_AUTHZ_NONE, // dwAuthzSvc
            0, // pServerPrincName
            RPC_C_AUTHN_LEVEL_DEFAULT, // dwAuthnLevel
            RPC_C_IMP_LEVEL_IMPERSONATE, // dwImpLevel
            pAuth, // pAuthInfo
            EOAC_NONE); // dwCapabilities
        
         Console.WriteLine("CoSetProxyBlanket for IDispatch returned " + hr);
         if (hr != 0)
            return;

         object actualReturnValue = typeInfo.InvokeMember("TestMe", BindingFlags.Default|BindingFlags.InvokeMethod,null,objDCOM,null,null,null,null);
         Console.WriteLine("Done");
      }
	}
}
