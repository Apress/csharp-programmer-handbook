using System;
using System.Runtime.InteropServices;

namespace LSA2
{
	[StructLayout(LayoutKind.Explicit, Size=24)]
	public struct OBJECT_ATTRIBUTES
	{
		[FieldOffset(0)]
		public uint Length;

		[FieldOffset(4)]
		public unsafe void* RootDirectory;

		[FieldOffset(8)]
		public unsafe LSA_UNICODE_STRING* ObjectName;

		[FieldOffset(12)]
		public uint Attributes;

		[FieldOffset(16)]
		public unsafe void* SecurityDescriptor;

		[FieldOffset(20)]
		public unsafe void* SecurityQualityOfService;
	}

	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct LSA_UNICODE_STRING
	{
		[FieldOffset(0)]
		public ushort Length;

		[FieldOffset(2)]
		public ushort MaximumLength;

		[FieldOffset(4)]
		public unsafe ushort* Buffer;
	}

	[StructLayout(LayoutKind.Explicit, Size=12)]
	public struct LSA_TRUST_INFORMATION
	{
		[FieldOffset(0)]
		public LSA_UNICODE_STRING Name;

		[FieldOffset(8)]
		public unsafe void* Sid;
	}


	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct LSA_REFERENCED_DOMAIN_LIST
	{
		[FieldOffset(0)]
		public uint Entries;

		[FieldOffset(4)]
		public unsafe LSA_TRUST_INFORMATION* Domains;
	}

	public enum SID_NAME_USE : int
	{
		SidTypeUser = 1,
		SidTypeGroup = 2,
		SidTypeDomain = 3,
		SidTypeAlias = 4,
		SidTypeWellKnownGroup = 5,
		SidTypeDeletedAccount = 6,
		SidTypeInvalid = 7,
		SidTypeUnknown = 8,
		SidTypeComputer = 9
	}

	[StructLayout(LayoutKind.Explicit, Size=16)]
	public struct LSA_TRANSLATED_SID2
	{
		[FieldOffset(0)]
		public SID_NAME_USE Use;

		[FieldOffset(4)]
		public unsafe void* Sid;

		[FieldOffset(8)]
		public int DomainIndex;

		[FieldOffset(12)]
		public uint Flags;
	}
	
	class Class1
	{
		const int POLICY_VIEW_LOCAL_INFORMATION =			  0x00000001;
		const int POLICY_VIEW_AUDIT_INFORMATION  =            0x00000002;
		const int POLICY_GET_PRIVATE_INFORMATION  =           0x00000004;
		const int POLICY_TRUST_ADMIN               =          0x00000008;
		const int POLICY_CREATE_ACCOUNT            =          0x00000010;
		const int POLICY_CREATE_SECRET             =          0x00000020;
		const int POLICY_CREATE_PRIVILEGE          =          0x00000040;
		const int POLICY_SET_DEFAULT_QUOTA_LIMITS  =          0x00000080;
		const int POLICY_SET_AUDIT_REQUIREMENTS    =          0x00000100;
		const int POLICY_AUDIT_LOG_ADMIN           =          0x00000200;
		const int POLICY_SERVER_ADMIN              =          0x00000400;
		const int POLICY_LOOKUP_NAMES              =          0x00000800;
		const int POLICY_NOTIFICATION              =          0x00001000;

		const int	POLICY_ALL_ACCESS     =	//STANDARD_RIGHTS_REQUIRED         |
											POLICY_VIEW_LOCAL_INFORMATION    |
											POLICY_VIEW_AUDIT_INFORMATION    |
											POLICY_GET_PRIVATE_INFORMATION   |
											POLICY_TRUST_ADMIN               |
											POLICY_CREATE_ACCOUNT            |
											POLICY_CREATE_SECRET             |
											POLICY_CREATE_PRIVILEGE          |
											POLICY_SET_DEFAULT_QUOTA_LIMITS  |
											POLICY_SET_AUDIT_REQUIREMENTS    |
											POLICY_AUDIT_LOG_ADMIN           |
											POLICY_SERVER_ADMIN              |
											POLICY_LOOKUP_NAMES;

		
		[DllImport(@"advapi32", EntryPoint="LsaOpenPolicy", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int LsaOpenPolicy(	IntPtr SystemName, 
														IntPtr ObjectAttributes, 
														uint DesiredAccess, 
														[In, Out] int* PolicyHandle);

		[DllImport(@"advapi32", EntryPoint="LsaLookupNames2", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int LsaLookupNames2(	[In] int PolicyHandle, 
															uint Flags,
															uint Count, 
															LSA_UNICODE_STRING[] SystemName, 
															[Out] LSA_REFERENCED_DOMAIN_LIST** ReferencedDomains, 
															[Out] LSA_TRANSLATED_SID2** Sids);

		
		[STAThread]
		static unsafe void Main(string[] args)
		{
			OBJECT_ATTRIBUTES objAtt;
			objAtt.Attributes = 0;
			objAtt.Length = 0;
			objAtt.ObjectName = null;
			objAtt.RootDirectory = null;
			objAtt.SecurityDescriptor = null;
			objAtt.SecurityQualityOfService = null;

			IntPtr Temp = Marshal.AllocCoTaskMem(Marshal.SizeOf(typeof(OBJECT_ATTRIBUTES)));
			Marshal.StructureToPtr(objAtt, Temp, false);
			
			
			int* Policy = (int*)Marshal.AllocCoTaskMem(4);

			try
			{
				LSA_UNICODE_STRING ServerName = new LSA_UNICODE_STRING();
				ServerName.Length = 18;
				ServerName.MaximumLength = 20;
				ServerName.Buffer = (ushort*)Marshal.StringToCoTaskMemUni(@"\\dsaddc3");

				IntPtr Server = Marshal.AllocCoTaskMem(Marshal.SizeOf(typeof(LSA_UNICODE_STRING)));
				Marshal.StructureToPtr(ServerName, Server, false);



				int hr = LsaOpenPolicy(				Server,
													Temp,
													POLICY_ALL_ACCESS,
													Policy);
				
				Console.WriteLine("{0} LsaOpenPolicy=", hr);

				/*LSA_UNICODE_STRING[] UserName = new LSA_UNICODE_STRING[1];
				UserName[0].Length = 30;
				UserName[0].MaximumLength = 30;
				UserName[0].Buffer = (ushort*)Marshal.StringToCoTaskMemUni(@"dsaddom\gregmcb");*/

				LSA_UNICODE_STRING[] UserName = new LSA_UNICODE_STRING[1];
				UserName[0].Length = 24;
				UserName[0].MaximumLength = 24;
				UserName[0].Buffer = (ushort*)Marshal.StringToCoTaskMemUni(@"S-1-5-32-548");

				/*Causes C000018c error
				LSA_UNICODE_STRING[] UserName = new LSA_UNICODE_STRING[1];
				UserName[0].Length = 24;
				UserName[0].MaximumLength = 24;
				UserName[0].Buffer = (ushort*)Marshal.StringToCoTaskMemUni(@"S-1-5-32-554");*/

				
				LSA_REFERENCED_DOMAIN_LIST* pDomain = null;
				LSA_TRANSLATED_SID2* pSIDs = null;
				
				
				hr = LsaLookupNames2(				*Policy, 
													0,1, 
													UserName, 
													&pDomain, 
													&pSIDs);
				
				
				Console.WriteLine("0X{0:x} LsaLookupNames2=", hr);



			}
			catch(Exception e)
			{
				Console.WriteLine(e);
			}
												
			

		}
	}
}


