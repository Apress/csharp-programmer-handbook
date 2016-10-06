using System;
using System.Runtime.InteropServices;

//generated on 6/5/2003 at 2:42:59 PM
namespace LDAP.ActiveDS
{
	#region forwarder functions (10)
	/*
	Forwarder functions are those that are actually specified in another DLL.
	The following list includes the name & where the actual function defintion
	can be accessed (DLL.functionName

	ADsDecodeBinaryData	ADSLDPC.ADsDecodeBinaryData
	ADsEncodeBinaryData	ADSLDPC.ADsEncodeBinaryData
	ADsGetLastError	ADSLDPC.ADsGetLastError
	ADsSetLastError	ADSLDPC.ADsSetLastError
	AllocADsMem	ADSLDPC.AllocADsMem
	AllocADsStr	ADSLDPC.AllocADsStr
	FreeADsMem	ADSLDPC.FreeADsMem
	FreeADsStr	ADSLDPC.FreeADsStr
	ReallocADsMem	ADSLDPC.ReallocADsMem
	ReallocADsStr	ADSLDPC.ReallocADsStr

	*/
	#endregion

	class Activeds
	{
		//Common Interface Defintions
		
		//20 functions were generated: C:\DBG\PDB2CS\src\release\activeds.dll

		[DllImport(@"activeds", EntryPoint="ConvertSecDescriptorToVariant", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int ConvertSecDescriptorToVariant(ushort* pszServerName, CCredentials* Credentials, void* pSecurityDescriptor, VARIANT* pVarSec, int fNTDS);

		[DllImport(@"activeds", EntryPoint="ConvertSecurityDescriptorToSecDes", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int ConvertSecurityDescriptorToSecDes(ushort* pszServerName, CCredentials* Credentials, IADsSecurityDescriptor* pSecDes, void** ppSecurityDescriptor, uint* pdwSDLength, int fNTDSType);

		[DllImport(@"activeds", EntryPoint="DllUnregisterServer", CallingConvention=CallingConvention.StdCall)]
		public static extern int DllUnregisterServer();

		[DllImport(@"activeds", EntryPoint="PropVariantToAdsType", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int PropVariantToAdsType(VARIANT* pVariant, uint dwNumVariant, ADSVALUE** ppAdsValues, uint* pdwNumValues);

		[DllImport(@"activeds", EntryPoint="AdsTypeToPropVariant", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int AdsTypeToPropVariant(ADSVALUE* pAdsValues, uint dwNumValues, VARIANT* pVarDestObjects);

		[DllImport(@"activeds", EntryPoint="ADsGetObject", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int ADsGetObject(ushort* lpszPathName, GUID* riid, void** ppObject);

		[DllImport(@"activeds", EntryPoint="DllRegisterServer", CallingConvention=CallingConvention.StdCall)]
		public static extern int DllRegisterServer();

		[DllImport(@"activeds", EntryPoint="SecurityDescriptorToBinarySD", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int SecurityDescriptorToBinarySD(VARIANT vVarSecDes, void** ppSecurityDescriptor, uint* pdwSDLength, ushort* pszServerName, ushort* userName, ushort* passWord, uint dwFlags);

		[DllImport(@"activeds", EntryPoint="AdsFreeAdsValues", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe void AdsFreeAdsValues(ADSVALUE* pAdsValues, uint dwNumValues);

		[DllImport(@"activeds", EntryPoint="PropVariantToAdsType2", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int PropVariantToAdsType2(VARIANT* pVariant, uint dwNumVariant, ADSVALUE** ppAdsValues, uint* pdwNumValues, ushort* pszServerName, CCredentials* pCredentials, int fNTDSType);

		[DllImport(@"activeds", EntryPoint="ADsOpenObject", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int ADsOpenObject(ushort* lpszPathName, ushort* lpszUserName, ushort* lpszPassword, uint dwReserved, GUID* riid, void** ppObject);

		[DllImport(@"activeds", EntryPoint="DllCanUnloadNow", CallingConvention=CallingConvention.StdCall)]
		public static extern int DllCanUnloadNow();

		[DllImport(@"activeds", EntryPoint="ADsBuildVarArrayInt", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int ADsBuildVarArrayInt(uint* lpdwObjectTypes, uint dwObjectTypes, VARIANT* pVar);

		[DllImport(@"activeds", EntryPoint="ADsEnumerateNext", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int ADsEnumerateNext(ENUMVARIANT* pEnumVariant, uint cElements, VARIANT* pvar, uint* pcElementsFetched);

		[DllImport(@"activeds", EntryPoint="ADsBuildEnumerator", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int ADsBuildEnumerator(IADsContainer* pADsContainer, ENUMVARIANT** ppEnumVariant);

		[DllImport(@"activeds", EntryPoint="BinarySDToSecurityDescriptor", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int BinarySDToSecurityDescriptor(void* pSecurityDescriptor, VARIANT* pVarsec, ushort* pszServerName, ushort* userName, ushort* passWord, uint dwFlags);

		[DllImport(@"activeds", EntryPoint="AdsTypeToPropVariant2", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int AdsTypeToPropVariant2(ADSVALUE* pAdsValues, uint dwNumValues, VARIANT* pVarDestObjects, ushort* pszServerName, CCredentials* pCredentials, int fNTDSType);

		[DllImport(@"activeds", EntryPoint="DllGetClassObject", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int DllGetClassObject(GUID* clsid, GUID* iid, void** ppv);

		[DllImport(@"activeds", EntryPoint="ADsFreeEnumerator", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int ADsFreeEnumerator(ENUMVARIANT* pEnumVariant);

		[DllImport(@"activeds", EntryPoint="ADsBuildVarArrayStr", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int ADsBuildVarArrayStr(ushort** lppPathNames, uint dwPathNames, VARIANT* pVar);

	}

	#region structs (33)

	[StructLayout(LayoutKind.Explicit, Size=12)]
	public struct ADS_PATH
	{
		[FieldOffset(0)]
		public uint Type;

		[FieldOffset(4)]
		public unsafe ushort* VolumeName;

		[FieldOffset(8)]
		public unsafe ushort* Path;
	}

	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct ADS_BACKLINK
	{
		[FieldOffset(0)]
		public uint RemoteID;

		[FieldOffset(4)]
		public unsafe ushort* ObjectName;
	}

	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct ADS_EMAIL
	{
		[FieldOffset(0)]
		public unsafe ushort* Address;

		[FieldOffset(4)]
		public uint Type;
	}

	[StructLayout(LayoutKind.Explicit, Size=12)]
	public struct ADS_TYPEDNAME
	{
		[FieldOffset(0)]
		public unsafe ushort* ObjectName;

		[FieldOffset(4)]
		public uint Level;

		[FieldOffset(8)]
		public uint Interval;
	}

	[StructLayout(LayoutKind.Explicit, Size=24)]
	public struct ADSVALUE
	{
		[FieldOffset(0)]
		public ADSTYPEENUM dwType;

		[FieldOffset(8)]
		public unsafe ushort* DNString;

		[FieldOffset(8)]
		public unsafe ushort* CaseExactString;

		[FieldOffset(8)]
		public unsafe ushort* CaseIgnoreString;

		[FieldOffset(8)]
		public unsafe ushort* PrintableString;

		[FieldOffset(8)]
		public unsafe ushort* NumericString;

		[FieldOffset(8)]
		public uint Boolean;

		[FieldOffset(8)]
		public uint Integer;

		[FieldOffset(8)]
		public ADS_OCTET_STRING OctetString;

		[FieldOffset(8)]
		public SYSTEMTIME UTCTime;

		[FieldOffset(8)]
		public LARGE_INTEGER LargeInteger;

		[FieldOffset(8)]
		public unsafe ushort* ClassName;

		[FieldOffset(8)]
		public ADS_PROV_SPECIFIC ProviderSpecific;

		[FieldOffset(8)]
		public unsafe ADS_CASEIGNORE_LIST* pCaseIgnoreList;

		[FieldOffset(8)]
		public unsafe ADS_OCTET_LIST* pOctetList;

		[FieldOffset(8)]
		public unsafe ADS_PATH* pPath;

		[FieldOffset(8)]
		public unsafe ADS_POSTALADDRESS* pPostalAddress;

		[FieldOffset(8)]
		public ADS_TIMESTAMP Timestamp;

		[FieldOffset(8)]
		public ADS_BACKLINK BackLink;

		[FieldOffset(8)]
		public unsafe ADS_TYPEDNAME* pTypedName;

		[FieldOffset(8)]
		public ADS_HOLD Hold;

		[FieldOffset(8)]
		public unsafe ADS_NETADDRESS* pNetAddress;

		[FieldOffset(8)]
		public unsafe ADS_REPLICAPOINTER* pReplicaPointer;

		[FieldOffset(8)]
		public unsafe ADS_FAXNUMBER* pFaxNumber;

		[FieldOffset(8)]
		public ADS_EMAIL Email;

		[FieldOffset(8)]
		public ADS_NT_SECURITY_DESCRIPTOR SecurityDescriptor;

		[FieldOffset(8)]
		public unsafe ADS_DN_WITH_BINARY* pDNWithBinary;

		[FieldOffset(8)]
		public unsafe ADS_DN_WITH_STRING* pDNWithString;
	}

	[StructLayout(LayoutKind.Explicit, Size=16)]
	public struct DECIMAL
	{
		[FieldOffset(0)]
		public ushort wReserved;

		[FieldOffset(2)]
		public byte scale;

		[FieldOffset(3)]
		public byte sign;

		[FieldOffset(2)]
		public ushort signscale;

		[FieldOffset(4)]
		public uint Hi32;

		[FieldOffset(8)]
		public uint Lo32;

		[FieldOffset(12)]
		public uint Mid32;

		[FieldOffset(8)]
		public ulong Lo64;
	}

	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct ADS_HOLD
	{
		[FieldOffset(0)]
		public unsafe ushort* ObjectName;

		[FieldOffset(4)]
		public uint Amount;
	}

	[StructLayout(LayoutKind.Explicit, Size=4)]
	public struct UNKNOWN
	{
		//skipping UNKNOWN.unnamed

		//skipping UNKNOWN.QueryInterface

		//skipping UNKNOWN.AddRef

		//skipping UNKNOWN.Release

		//skipping UNKNOWN.IUnknown

		//skipping UNKNOWN.IUnknown
	}

	[StructLayout(LayoutKind.Explicit, Size=24)]
	public struct SAFEARRAY
	{
		[FieldOffset(0)]
		public ushort cDims;

		[FieldOffset(2)]
		public ushort fFeatures;

		[FieldOffset(4)]
		public uint cbElements;

		[FieldOffset(8)]
		public uint cLocks;

		[FieldOffset(12)]
		public unsafe void* pvData;

		//Fixed-length Array "rgsabound[1]". Members can be
		//accessed with (&my_SAFEARRAY.rgsabound_1)[index]
		[FieldOffset(16)]
		public SAFEARRAYBOUND rgsabound_1;
	}

	[StructLayout(LayoutKind.Explicit, Size=4)]
	public struct IADsSecurityDescriptor
	{
		//skipping IADsSecurityDescriptor.IDispatch

		//skipping IADsSecurityDescriptor.get_Revision

		//skipping IADsSecurityDescriptor.put_Revision

		//skipping IADsSecurityDescriptor.get_Control

		//skipping IADsSecurityDescriptor.put_Control

		//skipping IADsSecurityDescriptor.get_Owner

		//skipping IADsSecurityDescriptor.put_Owner

		//skipping IADsSecurityDescriptor.get_OwnerDefaulted

		//skipping IADsSecurityDescriptor.put_OwnerDefaulted

		//skipping IADsSecurityDescriptor.get_Group

		//skipping IADsSecurityDescriptor.put_Group

		//skipping IADsSecurityDescriptor.get_GroupDefaulted

		//skipping IADsSecurityDescriptor.put_GroupDefaulted

		//skipping IADsSecurityDescriptor.get_DiscretionaryAcl

		//skipping IADsSecurityDescriptor.put_DiscretionaryAcl

		//skipping IADsSecurityDescriptor.get_DaclDefaulted

		//skipping IADsSecurityDescriptor.put_DaclDefaulted

		//skipping IADsSecurityDescriptor.get_SystemAcl

		//skipping IADsSecurityDescriptor.put_SystemAcl

		//skipping IADsSecurityDescriptor.get_SaclDefaulted

		//skipping IADsSecurityDescriptor.put_SaclDefaulted

		//skipping IADsSecurityDescriptor.CopySecurityDescriptor

		//skipping IADsSecurityDescriptor.IADsSecurityDescriptor

		//skipping IADsSecurityDescriptor.IADsSecurityDescriptor
	}

	[StructLayout(LayoutKind.Explicit, Size=4)]
	public struct DISPATCH
	{
		//skipping DISPATCH.IUnknown

		//skipping DISPATCH.GetTypeInfoCount

		//skipping DISPATCH.GetTypeInfo

		//skipping DISPATCH.GetIDsOfNames

		//skipping DISPATCH.Invoke

		//skipping DISPATCH.IDispatch

		//skipping DISPATCH.IDispatch
	}

	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct ADS_NT_SECURITY_DESCRIPTOR
	{
		[FieldOffset(0)]
		public uint dwLength;

		[FieldOffset(4)]
		public unsafe byte* lpValue;
	}

	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct ADS_TIMESTAMP
	{
		[FieldOffset(0)]
		public uint WholeSeconds;

		[FieldOffset(4)]
		public uint EventID;
	}

	[StructLayout(LayoutKind.Explicit, Size=16)]
	public struct GUID
	{
		[FieldOffset(0)]
		public uint Data1;

		[FieldOffset(4)]
		public ushort Data2;

		[FieldOffset(6)]
		public ushort Data3;

		//Fixed-length Array "Data4[8]". Members can be
		//accessed with (&my_GUID.Data4_8)[index]
		[FieldOffset(8)]
		public byte Data4_8;
	}

	[StructLayout(LayoutKind.Explicit, Size=16)]
	public struct VARIANT
	{
		[FieldOffset(0)]
		public ushort vt;

		[FieldOffset(2)]
		public ushort wReserved1;

		[FieldOffset(4)]
		public ushort wReserved2;

		[FieldOffset(6)]
		public ushort wReserved3;

		[FieldOffset(8)]
		public long llVal;

		[FieldOffset(8)]
		public int lVal;

		[FieldOffset(8)]
		public byte bVal;

		[FieldOffset(8)]
		public short iVal;

		[FieldOffset(8)]
		public float fltVal;

		[FieldOffset(8)]
		public double dblVal;

		[FieldOffset(8)]
		public short boolVal;

		[FieldOffset(8)]
		public int scode;

		[FieldOffset(8)]
		public CY cyVal;

		[FieldOffset(8)]
		public double date;

		[FieldOffset(8)]
		public unsafe ushort* bstrVal;

		[FieldOffset(8)]
		public unsafe UNKNOWN* punkVal;

		[FieldOffset(8)]
		public unsafe DISPATCH* pdispVal;

		[FieldOffset(8)]
		public unsafe SAFEARRAY* parray;

		[FieldOffset(8)]
		public unsafe byte* pbVal;

		[FieldOffset(8)]
		public unsafe short* piVal;

		[FieldOffset(8)]
		public unsafe int* plVal;

		[FieldOffset(8)]
		public unsafe long* pllVal;

		[FieldOffset(8)]
		public unsafe float* pfltVal;

		[FieldOffset(8)]
		public unsafe double* pdblVal;

		[FieldOffset(8)]
		public unsafe short* pboolVal;

		[FieldOffset(8)]
		public unsafe int* pscode;

		[FieldOffset(8)]
		public unsafe CY* pcyVal;

		[FieldOffset(8)]
		public unsafe double* pdate;

		[FieldOffset(8)]
		public unsafe ushort** pbstrVal;

		[FieldOffset(8)]
		public unsafe UNKNOWN** ppunkVal;

		[FieldOffset(8)]
		public unsafe DISPATCH** ppdispVal;

		[FieldOffset(8)]
		public unsafe SAFEARRAY** pparray;

		[FieldOffset(8)]
		public unsafe VARIANT* pvarVal;

		[FieldOffset(8)]
		public unsafe void* byref;

		[FieldOffset(8)]
		public sbyte cVal;

		[FieldOffset(8)]
		public ushort uiVal;

		[FieldOffset(8)]
		public uint ulVal;

		[FieldOffset(8)]
		public ulong ullVal;

		[FieldOffset(8)]
		public int intVal;

		[FieldOffset(8)]
		public uint uintVal;

		[FieldOffset(8)]
		public unsafe DECIMAL* pdecVal;

		[FieldOffset(8)]
		public unsafe sbyte* pcVal;

		[FieldOffset(8)]
		public unsafe ushort* puiVal;

		[FieldOffset(8)]
		public unsafe uint* pulVal;

		[FieldOffset(8)]
		public unsafe ulong* pullVal;

		[FieldOffset(8)]
		public unsafe int* pintVal;

		[FieldOffset(8)]
		public unsafe uint* puintVal;

		[FieldOffset(8)]
		public unsafe void* pvRecord;

		[FieldOffset(12)]
		public unsafe RECORDINFO* pRecInfo;

		[FieldOffset(0)]
		public DECIMAL decVal;
	}

	[StructLayout(LayoutKind.Explicit, Size=12)]
	public struct ADS_FAXNUMBER
	{
		[FieldOffset(0)]
		public unsafe ushort* TelephoneNumber;

		[FieldOffset(4)]
		public uint NumberOfBits;

		[FieldOffset(8)]
		public unsafe byte* Parameters;
	}

	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct ADS_CASEIGNORE_LIST
	{
		[FieldOffset(0)]
		public unsafe ADS_CASEIGNORE_LIST* Next;

		[FieldOffset(4)]
		public unsafe ushort* String;
	}

	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct LARGE_INTEGER
	{
		[FieldOffset(0)]
		public uint LowPart;

		[FieldOffset(4)]
		public int HighPart;

		[FieldOffset(0)]
		public nested_u u;
		[StructLayout(LayoutKind.Explicit, Size=8)]
		public struct nested_u
		{
			[FieldOffset(0)]
			public uint LowPart;

			[FieldOffset(4)]
			public int HighPart;
		}

		[FieldOffset(0)]
		public long QuadPart;
	}

	[StructLayout(LayoutKind.Explicit, Size=12)]
	public struct ADS_NETADDRESS
	{
		[FieldOffset(0)]
		public uint AddressType;

		[FieldOffset(4)]
		public uint AddressLength;

		[FieldOffset(8)]
		public unsafe byte* Address;
	}

	[StructLayout(LayoutKind.Explicit, Size=12)]
	public struct ADS_DN_WITH_BINARY
	{
		[FieldOffset(0)]
		public uint dwLength;

		[FieldOffset(4)]
		public unsafe byte* lpBinaryValue;

		[FieldOffset(8)]
		public unsafe ushort* pszDNString;
	}

	[StructLayout(LayoutKind.Explicit, Size=4)]
	public struct ENUMVARIANT
	{
		//skipping ENUMVARIANT.IUnknown

		//skipping ENUMVARIANT.Next

		//skipping ENUMVARIANT.Skip

		//skipping ENUMVARIANT.Reset

		//skipping ENUMVARIANT.Clone

		//skipping ENUMVARIANT.IEnumVARIANT

		//skipping ENUMVARIANT.IEnumVARIANT
	}

	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct ADS_OCTET_STRING
	{
		[FieldOffset(0)]
		public uint dwLength;

		[FieldOffset(4)]
		public unsafe byte* lpValue;
	}

	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct CY
	{
		[FieldOffset(0)]
		public uint Lo;

		[FieldOffset(4)]
		public int Hi;

		[FieldOffset(0)]
		public long int64;
	}

	[StructLayout(LayoutKind.Explicit, Size=4)]
	public struct IADsContainer
	{
		//skipping IADsContainer.IDispatch

		//skipping IADsContainer.get_Count

		//skipping IADsContainer.get__NewEnum

		//skipping IADsContainer.get_Filter

		//skipping IADsContainer.put_Filter

		//skipping IADsContainer.get_Hints

		//skipping IADsContainer.put_Hints

		//skipping IADsContainer.GetObjectW

		//skipping IADsContainer.Create

		//skipping IADsContainer.Delete

		//skipping IADsContainer.CopyHere

		//skipping IADsContainer.MoveHere

		//skipping IADsContainer.IADsContainer

		//skipping IADsContainer.IADsContainer
	}

	[StructLayout(LayoutKind.Explicit, Size=16)]
	public struct CCredentials
	{
		//skipping CCredentials.CCredentials::CCredentials

		//skipping CCredentials.CCredentials::CCredentials

		//skipping CCredentials.CCredentials::CCredentials

		//skipping CCredentials.CCredentials::~CCredentials

		//skipping CCredentials.CCredentials::GetUserNameW

		//skipping CCredentials.CCredentials::GetPassword

		//skipping CCredentials.CCredentials::SetUserName

		//skipping CCredentials.CCredentials::SetPassword

		//skipping CCredentials.IsNullCredentials

		//skipping CCredentials.CCredentials::GetAuthFlags

		//skipping CCredentials.CCredentials::SetAuthFlags

		[FieldOffset(0)]
		public unsafe ushort* _lpszUserName;

		[FieldOffset(4)]
		public unsafe ushort* _lpszPassword;

		[FieldOffset(8)]
		public uint _dwAuthFlags;

		[FieldOffset(12)]
		public uint _dwPasswordLen;

		//skipping CCredentials.__vecDelDtor
	}

	[StructLayout(LayoutKind.Explicit, Size=20)]
	public struct ADS_REPLICAPOINTER
	{
		[FieldOffset(0)]
		public unsafe ushort* ServerName;

		[FieldOffset(4)]
		public uint ReplicaType;

		[FieldOffset(8)]
		public uint ReplicaNumber;

		[FieldOffset(12)]
		public uint Count;

		[FieldOffset(16)]
		public unsafe ADS_NETADDRESS* ReplicaAddressHints;
	}

	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct ADS_PROV_SPECIFIC
	{
		[FieldOffset(0)]
		public uint dwLength;

		[FieldOffset(4)]
		public unsafe byte* lpValue;
	}

	[StructLayout(LayoutKind.Explicit, Size=24)]
	public struct ADS_POSTALADDRESS
	{
		//Fixed-length Array "PostalAddress[6]". Members can be
		//accessed with (&my_ADS_POSTALADDRESS.PostalAddress_6)[index]
		[FieldOffset(0)]
		public unsafe ushort* PostalAddress_6;
	}

	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct ADS_DN_WITH_STRING
	{
		[FieldOffset(0)]
		public unsafe ushort* pszStringValue;

		[FieldOffset(4)]
		public unsafe ushort* pszDNString;
	}

	[StructLayout(LayoutKind.Explicit, Size=4)]
	public struct RECORDINFO
	{
		//skipping RECORDINFO.IUnknown

		//skipping RECORDINFO.RecordInit

		//skipping RECORDINFO.RecordClear

		//skipping RECORDINFO.RecordCopy

		//skipping RECORDINFO.GetGuid

		//skipping RECORDINFO.GetName

		//skipping RECORDINFO.GetSize

		//skipping RECORDINFO.GetTypeInfo

		//skipping RECORDINFO.GetField

		//skipping RECORDINFO.GetFieldNoCopy

		//skipping RECORDINFO.PutField

		//skipping RECORDINFO.PutFieldNoCopy

		//skipping RECORDINFO.GetFieldNames

		//skipping RECORDINFO.IsMatchingType

		//skipping RECORDINFO.RecordCreate

		//skipping RECORDINFO.RecordCreateCopy

		//skipping RECORDINFO.RecordDestroy

		//skipping RECORDINFO.IRecordInfo

		//skipping RECORDINFO.IRecordInfo
	}

	[StructLayout(LayoutKind.Explicit, Size=16)]
	public struct SYSTEMTIME
	{
		[FieldOffset(0)]
		public ushort wYear;

		[FieldOffset(2)]
		public ushort wMonth;

		[FieldOffset(4)]
		public ushort wDayOfWeek;

		[FieldOffset(6)]
		public ushort wDay;

		[FieldOffset(8)]
		public ushort wHour;

		[FieldOffset(10)]
		public ushort wMinute;

		[FieldOffset(12)]
		public ushort wSecond;

		[FieldOffset(14)]
		public ushort wMilliseconds;
	}

	[StructLayout(LayoutKind.Explicit, Size=12)]
	public struct ADS_OCTET_LIST
	{
		[FieldOffset(0)]
		public unsafe ADS_OCTET_LIST* Next;

		[FieldOffset(4)]
		public uint Length;

		[FieldOffset(8)]
		public unsafe byte* Data;
	}

	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct SAFEARRAYBOUND
	{
		[FieldOffset(0)]
		public uint cElements;

		[FieldOffset(4)]
		public int lLbound;
	}
	#endregion

	#region enums (1)

	public enum ADSTYPEENUM : int
	{
		ADSTYPE_INVALID = 0,
		ADSTYPE_DN_STRING = 1,
		ADSTYPE_CASE_EXACT_STRING = 2,
		ADSTYPE_CASE_IGNORE_STRING = 3,
		ADSTYPE_PRINTABLE_STRING = 4,
		ADSTYPE_NUMERIC_STRING = 5,
		ADSTYPE_BOOLEAN = 6,
		ADSTYPE_INTEGER = 7,
		ADSTYPE_OCTET_STRING = 8,
		ADSTYPE_UTC_TIME = 9,
		ADSTYPE_LARGE_INTEGER = 10,
		ADSTYPE_PROV_SPECIFIC = 11,
		ADSTYPE_OBJECT_CLASS = 12,
		ADSTYPE_CASEIGNORE_LIST = 13,
		ADSTYPE_OCTET_LIST = 14,
		ADSTYPE_PATH = 15,
		ADSTYPE_POSTALADDRESS = 16,
		ADSTYPE_TIMESTAMP = 17,
		ADSTYPE_BACKLINK = 18,
		ADSTYPE_TYPEDNAME = 19,
		ADSTYPE_HOLD = 20,
		ADSTYPE_NETADDRESS = 21,
		ADSTYPE_REPLICAPOINTER = 22,
		ADSTYPE_FAXNUMBER = 23,
		ADSTYPE_EMAIL = 24,
		ADSTYPE_NT_SECURITY_DESCRIPTOR = 25,
		ADSTYPE_UNKNOWN = 26,
		ADSTYPE_DN_WITH_BINARY = 27,
		ADSTYPE_DN_WITH_STRING = 28
	}
	#endregion
}

//comletion time: 2:42:59 PM
