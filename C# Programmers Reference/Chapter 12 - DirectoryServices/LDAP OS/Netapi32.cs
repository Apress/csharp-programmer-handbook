using System;
using System.Runtime.InteropServices;

//generated on 6/26/2003 at 5:17:41 PM
namespace LDAP.Netapi32
{
	class Netapi32
	{
		//331 functions were generated: C:\DBG\PDB2CS\src\release\netapi32.dll

		[DllImport(@"netapi32", EntryPoint="NetReplImportDirUnlock", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetReplImportDirUnlock(ushort* UncServerName, ushort* DirName, uint UnlockForce);

		[DllImport(@"netapi32", EntryPoint="I_BrowserResetNetlogonState", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_BrowserResetNetlogonState(ushort* servername);

		[DllImport(@"netapi32", EntryPoint="NetpwPathCanonicalize", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetpwPathCanonicalize(ushort* PathName, ushort* Outbuf, uint OutbufLen, ushort* Prefix, uint* PathType, uint Flags);

		[DllImport(@"netapi32", EntryPoint="NetReplImportDirAdd", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetReplImportDirAdd(ushort* UncServerName, uint Level, byte* Buf, uint* ParmError);

		[DllImport(@"netapi32", EntryPoint="I_NetLogonSendToSam", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int I_NetLogonSendToSam(ushort* PrimaryName, ushort* ComputerName, NETLOGON_AUTHENTICATOR* Authenticator, NETLOGON_AUTHENTICATOR* ReturnAuthenticator, byte* OpaqueBuffer, uint OpaqueBufferSize);

		[DllImport(@"netapi32", EntryPoint="NetLocalGroupAddMembers", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetLocalGroupAddMembers(ushort* ServerName, ushort* LocalGroupName, uint Level, byte* Buffer, uint NewMemberCount);

		[DllImport(@"netapi32", EntryPoint="I_NetDfsCreateLocalPartition", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_NetDfsCreateLocalPartition(ushort* servername, ushort* ShareName, GUID* EntryUid, ushort* EntryPrefix, ushort* ShortName, NET_DFS_ENTRY_ID_CONTAINER* RelationInfo, int Force);

		[DllImport(@"netapi32", EntryPoint="DsGetDcOpenA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsGetDcOpenA(sbyte* DnsName, uint OptionFlags, sbyte* SiteName, GUID* DomainGuid, sbyte* DnsForestName, uint DcFlags, void** RetGetDcContext);

		[DllImport(@"netapi32", EntryPoint="NetpParmsQueryUserProperty", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int NetpParmsQueryUserProperty(ushort* UserParms, ushort* PropertyName, ushort* PropertyFlag, UNICODE_STRING* PropertyValue);

		[DllImport(@"netapi32", EntryPoint="NetLocalGroupDel", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetLocalGroupDel(ushort* ServerName, ushort* LocalGroupName);

		[DllImport(@"netapi32", EntryPoint="NetDfsAddFtRoot", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetDfsAddFtRoot(ushort* ServerName, ushort* RootShare, ushort* FtDfsName, ushort* Comment, uint Flags);

		[DllImport(@"netapi32", EntryPoint="I_BrowserResetStatistics", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_BrowserResetStatistics(ushort* servername);

		[DllImport(@"netapi32", EntryPoint="I_NetServerAuthenticate", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int I_NetServerAuthenticate(ushort* PrimaryName, ushort* AccountName, NETLOGON_SECURE_CHANNEL_TYPE AccountType, ushort* ComputerName, CYPHER_BLOCK* ClientCredential, CYPHER_BLOCK* ServerCredential);

		[DllImport(@"netapi32", EntryPoint="NetRemoteComputerSupports", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetRemoteComputerSupports(ushort* UncServerName, uint OptionsWanted, uint* OptionsSupported);

		[DllImport(@"netapi32", EntryPoint="NetApiBufferFree", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetApiBufferFree(void* Buffer);

		[DllImport(@"netapi32", EntryPoint="NetpGetConfigBool", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetpGetConfigBool(void* ConfigHandle, ushort* KeyWanted, int DefaultValue, int* ValueBuffer);

		[DllImport(@"netapi32", EntryPoint="NetErrorLogWrite", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetErrorLogWrite(byte* Reserved1, uint Code, ushort* Component, byte* Buffer, uint NumBytes, byte* MsgBuf, uint StrCount, byte* Reserved2);

		[DllImport(@"netapi32", EntryPoint="DsDeregisterDnsHostRecordsA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsDeregisterDnsHostRecordsA(sbyte* ServerName, sbyte* DnsDomainName, GUID* DomainGuid, GUID* DsaGuid, sbyte* DnsHostName);

		[DllImport(@"netapi32", EntryPoint="I_NetlogonComputeClientDigest", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_NetlogonComputeClientDigest(ushort* ServerName, ushort* DomainName, byte* Message, uint MessageSize, sbyte* NewMessageDigest, sbyte* OldMessageDigest);

		[DllImport(@"netapi32", EntryPoint="NetScheduleJobEnum", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetScheduleJobEnum(ushort* ServerName, byte** PointerToBuffer, uint PreferredMaximumLength, uint* EntriesRead, uint* TotalEntries, uint* ResumeHandle);

		[DllImport(@"netapi32", EntryPoint="NetServerTransportAddEx", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetServerTransportAddEx(ushort* servername, uint level, byte* bufptr);

		[DllImport(@"netapi32", EntryPoint="DsGetDcOpenW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsGetDcOpenW(ushort* DnsName, uint OptionFlags, ushort* SiteName, GUID* DomainGuid, ushort* DnsForestName, uint DcFlags, void** RetGetDcContext);

		[DllImport(@"netapi32", EntryPoint="NetServerComputerNameAdd", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetServerComputerNameAdd(ushort* ServerName, ushort* EmulatedDomainName, ushort* EmulatedServerName);

		[DllImport(@"netapi32", EntryPoint="NetSessionGetInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetSessionGetInfo(ushort* servername, ushort* clientname, ushort* username, uint level, byte** bufptr);

		[DllImport(@"netapi32", EntryPoint="NetpLogonPutUnicodeString", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe void NetpLogonPutUnicodeString(ushort* String, uint MaxStringLength, sbyte** Where);

		[DllImport(@"netapi32", EntryPoint="NetDfsRemoveFtRootForced", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetDfsRemoveFtRootForced(ushort* DomainName, ushort* ServerName, ushort* RootShare, ushort* FtDfsName, uint Flags);

		[DllImport(@"netapi32", EntryPoint="NetServiceEnum", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetServiceEnum(ushort* servername, uint level, byte** bufptr, uint prefmaxlen, uint* entriesread, uint* totalentries, uint* resume_handle);

		[DllImport(@"netapi32", EntryPoint="NetWkstaUserEnum", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetWkstaUserEnum(ushort* servername, uint level, byte** bufptr, uint prefmaxlen, uint* entriesread, uint* totalentries, uint* resume_handle);

		[DllImport(@"netapi32", EntryPoint="NetUserEnum", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetUserEnum(ushort* ServerName, uint Level, uint Filter, byte** Buffer, uint PrefMaxLen, uint* EntriesRead, uint* EntriesLeft, uint* ResumeHandle);

		[DllImport(@"netapi32", EntryPoint="NetAuditRead", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetAuditRead(ushort* UncServerName, ushort* reserved1, HLOG* auditloghandle, uint offset, uint* reserved2, uint reserved3, uint offsetflag, byte** bufptr, uint prefmaxlen, uint* bytesread, uint* totalavailable);

		[DllImport(@"netapi32", EntryPoint="NetpNetBiosCall", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetpNetBiosCall(byte LanAdapterNumber, ushort* NameToCall, ushort* Sender, byte* SessionNumber);

		[DllImport(@"netapi32", EntryPoint="NetSessionDel", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetSessionDel(ushort* servername, ushort* clientname, ushort* username);

		[DllImport(@"netapi32", EntryPoint="NetEnumerateComputerNames", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetEnumerateComputerNames(ushort* Server, NET_COMPUTER_NAME_TYPE NameType, uint Reserved, uint* EntryCount, ushort*** ComputerNames);

		[DllImport(@"netapi32", EntryPoint="NetUserGetGroups", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetUserGetGroups(ushort* ServerName, ushort* UserName, uint Level, byte** Buffer, uint PrefMaxLen, uint* EntriesRead, uint* EntriesLeft);

		[DllImport(@"netapi32", EntryPoint="NetpAllocWStrFromStr", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe ushort* NetpAllocWStrFromStr(sbyte* Oem);

		[DllImport(@"netapi32", EntryPoint="I_NetLogonSamLogonWithFlags", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int I_NetLogonSamLogonWithFlags(ushort* LogonServer, ushort* ComputerName, NETLOGON_AUTHENTICATOR* Authenticator, NETLOGON_AUTHENTICATOR* ReturnAuthenticator, NETLOGON_LOGON_INFO_CLASS LogonLevel, byte* LogonInformation, NETLOGON_VALIDATION_INFO_CLASS ValidationLevel, byte** ValidationInformation, byte* Authoritative, uint* ExtraFlags);

		[DllImport(@"netapi32", EntryPoint="RxNetAccessEnum", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint RxNetAccessEnum(ushort* ServerName, ushort* BasePath, uint Recursive, uint Level, byte** Buffer, uint PrefMaxLen, uint* EntriesRead, uint* EntriesLeft, uint* ResumeHandle);

		[DllImport(@"netapi32", EntryPoint="NetGetDCName", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetGetDCName(ushort* ServerName, ushort* DomainName, byte** Buffer);

		[DllImport(@"netapi32", EntryPoint="NetDfsManagerGetConfigInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetDfsManagerGetConfigInfo(ushort* wszServer, ushort* wszLocalVolumeEntryPath, GUID guidLocalVolume, DFSM_RELATION_INFO** ppDfsmRelationInfo);

		[DllImport(@"netapi32", EntryPoint="I_NetlogonGetTrustRid", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_NetlogonGetTrustRid(ushort* ServerName, ushort* DomainName, uint* Rid);

		[DllImport(@"netapi32", EntryPoint="I_NetPathType", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_NetPathType(ushort* ServerName, ushort* PathName, uint* PathType, uint Flags);

		[DllImport(@"netapi32", EntryPoint="I_NetAccountDeltas", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_NetAccountDeltas(ushort* PrimaryName, ushort* ComputerName, NETLOGON_AUTHENTICATOR* Authenticator, NETLOGON_AUTHENTICATOR* ReturnAuthenticator, UAS_INFO_0* RecordId, uint Count, uint Level, byte* Buffer, uint BufferSize, uint* CountReturned, uint* TotalEntries, UAS_INFO_0* NextRecordId);

		[DllImport(@"netapi32", EntryPoint="NetLocalGroupEnum", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetLocalGroupEnum(ushort* ServerName, uint Level, byte** Buffer, uint PrefMaxLen, uint* EntriesRead, uint* EntriesLeft, uint* ResumeHandle);

		[DllImport(@"netapi32", EntryPoint="NetUserSetGroups", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetUserSetGroups(ushort* ServerName, ushort* UserName, uint Level, byte* Buffer, uint NewGroupCount);

		[DllImport(@"netapi32", EntryPoint="NetpwNameCanonicalize", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetpwNameCanonicalize(ushort* Name, ushort* Outbuf, uint OutbufLen, uint NameType, uint Flags);

		[DllImport(@"netapi32", EntryPoint="NetUnjoinDomain", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetUnjoinDomain(ushort* lpServer, ushort* lpAccount, ushort* lpPassword, uint fUnjoinOptions);

		[DllImport(@"netapi32", EntryPoint="NetLocalGroupAddMember", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetLocalGroupAddMember(ushort* ServerName, ushort* LocalGroupName, void* MemberSid);

		[DllImport(@"netapi32", EntryPoint="NetRenameMachineInDomain", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetRenameMachineInDomain(ushort* lpServer, ushort* lpNewMachineName, ushort* lpAccount, ushort* lpPassword, uint fRenameOptions);

		[DllImport(@"netapi32", EntryPoint="NetValidateName", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetValidateName(ushort* lpServer, ushort* lpName, ushort* lpAccount, ushort* lpPassword, NETSETUP_NAME_TYPE NameType);

		[DllImport(@"netapi32", EntryPoint="NetGroupGetInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetGroupGetInfo(ushort* ServerName, ushort* GroupName, uint Level, byte** Buffer);

		[DllImport(@"netapi32", EntryPoint="NetGroupDel", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetGroupDel(ushort* ServerName, ushort* GroupName);

		[DllImport(@"netapi32", EntryPoint="NetDfsRename", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetDfsRename(ushort* UncServerName, ushort* DirName);

		[DllImport(@"netapi32", EntryPoint="NetLogonGetTimeServiceParentDomain", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetLogonGetTimeServiceParentDomain(ushort* ServerName, ushort** DomainName, int* PdcSameSite);

		[DllImport(@"netapi32", EntryPoint="I_NetLogonControl2", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_NetLogonControl2(ushort* ServerName, uint FunctionCode, uint QueryLevel, byte* InputData, byte** QueryInformation);

		[DllImport(@"netapi32", EntryPoint="I_NetServerGetTrustInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int I_NetServerGetTrustInfo(ushort* TrustedDcName, ushort* AccountName, NETLOGON_SECURE_CHANNEL_TYPE AccountType, ushort* ComputerName, NETLOGON_AUTHENTICATOR* Authenticator, NETLOGON_AUTHENTICATOR* ReturnAuthenticator, ENCRYPTED_LM_OWF_PASSWORD* EncryptedNewOwfPassword, ENCRYPTED_LM_OWF_PASSWORD* EncryptedOldOwfPassword, NL_GENERIC_RPC_DATA** TrustInfo);

		[DllImport(@"netapi32", EntryPoint="NetReplExportDirAdd", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetReplExportDirAdd(ushort* UncServerName, uint Level, byte* Buf, uint* ParmError);

		[DllImport(@"netapi32", EntryPoint="DsMergeForestTrustInformationW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsMergeForestTrustInformationW(ushort* DomainName, LSA_FOREST_TRUST_INFORMATION* NewForestTrustInfo, LSA_FOREST_TRUST_INFORMATION* OldForestTrustInfo, LSA_FOREST_TRUST_INFORMATION** MergedForestTrustInfo);

		[DllImport(@"netapi32", EntryPoint="I_BrowserQueryEmulatedDomains", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_BrowserQueryEmulatedDomains(ushort* ServerName, BROWSER_EMULATED_DOMAIN** EmulatedDomains, uint* EntriesRead);

		[DllImport(@"netapi32", EntryPoint="NetUserSetInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetUserSetInfo(ushort* ServerName, ushort* UserName, uint Level, byte* Buffer, uint* ParmError);

		[DllImport(@"netapi32", EntryPoint="I_NetDatabaseSync", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int I_NetDatabaseSync(ushort* PrimaryName, ushort* ComputerName, NETLOGON_AUTHENTICATOR* Authenticator, NETLOGON_AUTHENTICATOR* ReturnAuthenticator, uint DatabaseID, uint* SamSyncContext, NETLOGON_DELTA_ENUM_ARRAY** DeltaArray, uint PreferredMaximumLength);

		[DllImport(@"netapi32", EntryPoint="NetGroupGetUsers", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetGroupGetUsers(ushort* ServerName, ushort* GroupName, uint Level, byte** Buffer, uint PrefMaxLen, uint* EntriesRead, uint* EntriesLeft, uint* ResumeHandle);

		[DllImport(@"netapi32", EntryPoint="NetpNetBiosReset", CallingConvention=CallingConvention.StdCall)]
		public static extern uint NetpNetBiosReset(byte LanAdapterNumber);

		[DllImport(@"netapi32", EntryPoint="DsGetDcNameWithAccountW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsGetDcNameWithAccountW(ushort* ComputerName, ushort* AccountName, uint AllowableAccountControlBits, ushort* DomainName, GUID* DomainGuid, ushort* SiteName, uint Flags, DOMAIN_CONTROLLER_INFOW** DomainControllerInfo);

		[DllImport(@"netapi32", EntryPoint="NetConfigSet", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetConfigSet(ushort* UncServerName, ushort* Reserved1, ushort* Component, uint Level, uint Reserved2, byte* Buf, uint Reserved3);

		[DllImport(@"netapi32", EntryPoint="NetpParmsQueryUserPropertyWithLength", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int NetpParmsQueryUserPropertyWithLength(UNICODE_STRING* UserParms, ushort* PropertyName, ushort* PropertyFlag, UNICODE_STRING* PropertyValue);

		[DllImport(@"netapi32", EntryPoint="NetGroupDelUser", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetGroupDelUser(ushort* ServerName, ushort* GroupName, ushort* UserName);

		[DllImport(@"netapi32", EntryPoint="NetShareGetInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetShareGetInfo(ushort* servername, ushort* netname, uint level, byte** bufptr);

		[DllImport(@"netapi32", EntryPoint="NetErrorLogClear", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetErrorLogClear(ushort* UncServerName, ushort* BackupFile, byte* Reserved);

		[DllImport(@"netapi32", EntryPoint="NetpCopyFtinfoContext", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe LSA_FOREST_TRUST_INFORMATION* NetpCopyFtinfoContext(NL_FTINFO_CONTEXT* FtinfoContext);

		[DllImport(@"netapi32", EntryPoint="I_NetLogonSamLogonEx", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int I_NetLogonSamLogonEx(void* ContextHandle, ushort* LogonServer, ushort* ComputerName, NETLOGON_LOGON_INFO_CLASS LogonLevel, byte* LogonInformation, NETLOGON_VALIDATION_INFO_CLASS ValidationLevel, byte** ValidationInformation, byte* Authoritative, uint* ExtraFlags, byte* RpcFailed);

		[DllImport(@"netapi32", EntryPoint="NetApiBufferAllocate", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetApiBufferAllocate(uint ByteCount, void** Buffer);

		[DllImport(@"netapi32", EntryPoint="NetGroupSetUsers", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetGroupSetUsers(ushort* ServerName, ushort* GroupName, uint Level, byte* Buffer, uint NewMemberCount);

		[DllImport(@"netapi32", EntryPoint="NetpGetConfigValue", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetpGetConfigValue(void* ConfigHandle, ushort* lptstrKeyword, ushort** ValueBufferPtr);

		[DllImport(@"netapi32", EntryPoint="NetReplExportDirDel", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetReplExportDirDel(ushort* UncServerName, ushort* DirName);

		[DllImport(@"netapi32", EntryPoint="NetFileClose", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetFileClose(ushort* servername, uint fileid);

		[DllImport(@"netapi32", EntryPoint="NetpMergeFtinfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int NetpMergeFtinfo(UNICODE_STRING* TrustedDomainName, LSA_FOREST_TRUST_INFORMATION* InNewForestTrustInfo, LSA_FOREST_TRUST_INFORMATION* InOldForestTrustInfo, LSA_FOREST_TRUST_INFORMATION** MergedForestTrustInfo);

		[DllImport(@"netapi32", EntryPoint="I_NetDatabaseSync2", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int I_NetDatabaseSync2(ushort* PrimaryName, ushort* ComputerName, NETLOGON_AUTHENTICATOR* Authenticator, NETLOGON_AUTHENTICATOR* ReturnAuthenticator, uint DatabaseID, SYNC_STATE RestartState, uint* SamSyncContext, NETLOGON_DELTA_ENUM_ARRAY** DeltaArray, uint PreferredMaximumLength);

		[DllImport(@"netapi32", EntryPoint="NetpGetConfigTStrArray", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetpGetConfigTStrArray(void* ConfigHandle, ushort* Keyword, ushort** ValueBuffer);

		[DllImport(@"netapi32", EntryPoint="I_NetDfsGetVersion", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_NetDfsGetVersion(ushort* servername, uint* Version);

		[DllImport(@"netapi32", EntryPoint="NetFileEnum", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetFileEnum(ushort* servername, ushort* basepath, ushort* username, uint level, byte** bufptr, uint prefmaxlen, uint* entriesread, uint* totalentries, uint* resume_handle);

		[DllImport(@"netapi32", EntryPoint="NetpNtStatusToApiStatus", CallingConvention=CallingConvention.StdCall)]
		public static extern uint NetpNtStatusToApiStatus(int NtStatus);

		[DllImport(@"netapi32", EntryPoint="NetUserModalsSet", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetUserModalsSet(ushort* ServerName, uint Level, byte* Buffer, uint* ParmError);

		[DllImport(@"netapi32", EntryPoint="NetServiceInstall", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetServiceInstall(ushort* servername, ushort* service, uint argc, ushort** argv, byte** bufptr);

		[DllImport(@"netapi32", EntryPoint="NetGetJoinInformation", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetGetJoinInformation(ushort* lpServer, ushort** lpNameBuffer, NETSETUP_JOIN_STATUS* BufferType);

		[DllImport(@"netapi32", EntryPoint="NetpAllocConfigName", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetpAllocConfigName(ushort* DatabaseName, ushort* ServiceName, ushort* AreaUnderServiceName, ushort** FullConfigName);

		[DllImport(@"netapi32", EntryPoint="NetShareDel", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetShareDel(ushort* servername, ushort* netname, uint reserved);

		[DllImport(@"netapi32", EntryPoint="I_NetLogonUasLogon", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_NetLogonUasLogon(ushort* UserName, ushort* Workstation, NETLOGON_VALIDATION_UAS_INFO** ValidationInformation);

		[DllImport(@"netapi32", EntryPoint="NetpInitFtinfoContext", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe void NetpInitFtinfoContext(NL_FTINFO_CONTEXT* FtinfoContext);

		[DllImport(@"netapi32", EntryPoint="NetpStringToNetBiosName", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetpStringToNetBiosName(sbyte* NetBiosName, ushort* String, uint CanonicalizeType, ushort Type);

		[DllImport(@"netapi32", EntryPoint="NetRemoteTOD", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetRemoteTOD(ushort* servername, byte** bufptr);

		[DllImport(@"netapi32", EntryPoint="RxNetAccessAdd", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint RxNetAccessAdd(ushort* ServerName, uint Level, byte* Buffer, uint* ParmError);

		[DllImport(@"netapi32", EntryPoint="I_NetDfsIsThisADomainName", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_NetDfsIsThisADomainName(ushort* wszName);

		[DllImport(@"netapi32", EntryPoint="NetApiBufferReallocate", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetApiBufferReallocate(void* OldBuffer, uint NewByteCount, void** NewBuffer);

		[DllImport(@"netapi32", EntryPoint="I_NetDfsCreateExitPoint", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_NetDfsCreateExitPoint(ushort* servername, GUID* Uid, ushort* Prefix, uint Type, uint ShortPrefixSize, ushort* ShortPrefix);

		[DllImport(@"netapi32", EntryPoint="NetpParmsUserPropertyFree", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe void NetpParmsUserPropertyFree(ushort* NewUserParms);

		[DllImport(@"netapi32", EntryPoint="NetUserGetInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetUserGetInfo(ushort* ServerName, ushort* UserName, uint Level, byte** Buffer);

		[DllImport(@"netapi32", EntryPoint="NetDfsEnum", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetDfsEnum(ushort* DfsName, uint Level, uint PrefMaxLen, byte** Buffer, uint* EntriesRead, uint* ResumeHandle);

		[DllImport(@"netapi32", EntryPoint="NetServerEnum", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetServerEnum(ushort* servername, uint level, byte** bufptr, uint prefmaxlen, uint* entriesread, uint* totalentries, uint servertype, ushort* domain, uint* resume_handle);

		[DllImport(@"netapi32", EntryPoint="NetGetDisplayInformationIndex", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetGetDisplayInformationIndex(ushort* ServerName, uint Level, ushort* Prefix, uint* Index);

		[DllImport(@"netapi32", EntryPoint="I_NetDatabaseRedo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int I_NetDatabaseRedo(ushort* PrimaryName, ushort* ComputerName, NETLOGON_AUTHENTICATOR* Authenticator, NETLOGON_AUTHENTICATOR* ReturnAuthenticator, byte* ChangeLogEntry, uint ChangeLogEntrySize, NETLOGON_DELTA_ENUM_ARRAY** DeltaArray);

		[DllImport(@"netapi32", EntryPoint="NetGroupSetInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetGroupSetInfo(ushort* ServerName, ushort* GroupName, uint Level, byte* Buffer, uint* ParmError);

		[DllImport(@"netapi32", EntryPoint="NetpAssertFailed", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe void NetpAssertFailed(sbyte* FailedAssertion, sbyte* FileName, uint LineNumber, sbyte* Message);

		[DllImport(@"netapi32", EntryPoint="I_BrowserQueryOtherDomains", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_BrowserQueryOtherDomains(ushort* servername, byte** bufptr, uint* entriesread, uint* totalentries);

		[DllImport(@"netapi32", EntryPoint="NetScheduleJobDel", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetScheduleJobDel(ushort* ServerName, uint MinJobId, uint MaxJobId);

		[DllImport(@"netapi32", EntryPoint="NlBindingRemoveServerFromCache", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int NlBindingRemoveServerFromCache(ushort* UncServerName, NL_RPC_BINDING RpcBindingType);

		[DllImport(@"netapi32", EntryPoint="I_BrowserQueryStatistics", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_BrowserQueryStatistics(ushort* servername, BROWSER_STATISTICS** Statistics);

		[DllImport(@"netapi32", EntryPoint="I_NetServerPasswordGet", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int I_NetServerPasswordGet(ushort* PrimaryName, ushort* AccountName, NETLOGON_SECURE_CHANNEL_TYPE AccountType, ushort* ComputerName, NETLOGON_AUTHENTICATOR* Authenticator, NETLOGON_AUTHENTICATOR* ReturnAuthenticator, ENCRYPTED_LM_OWF_PASSWORD* EncryptedNtOwfPassword);

		[DllImport(@"netapi32", EntryPoint="NetpAllocWStrFromWStr", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe ushort* NetpAllocWStrFromWStr(ushort* Unicode);

		[DllImport(@"netapi32", EntryPoint="RxNetAccessGetUserPerms", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint RxNetAccessGetUserPerms(ushort* ServerName, ushort* UserName, ushort* ResourceName, uint* Perms);

		[DllImport(@"netapi32", EntryPoint="I_NetLogonControl", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_NetLogonControl(ushort* ServerName, uint FunctionCode, uint QueryLevel, byte** QueryInformation);

		[DllImport(@"netapi32", EntryPoint="I_NetServerPasswordSet2", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int I_NetServerPasswordSet2(ushort* PrimaryName, ushort* AccountName, NETLOGON_SECURE_CHANNEL_TYPE AccountType, ushort* ComputerName, NETLOGON_AUTHENTICATOR* Authenticator, NETLOGON_AUTHENTICATOR* ReturnAuthenticator, NL_TRUST_PASSWORD* ClearNewPassword);

		[DllImport(@"netapi32", EntryPoint="DsRoleDnsNameToFlatName", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsRoleDnsNameToFlatName(ushort* lpServer, ushort* lpDnsName, ushort** lpFlatName, uint* lpStatusFlag);

		[DllImport(@"netapi32", EntryPoint="DsDeregisterDnsHostRecordsW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsDeregisterDnsHostRecordsW(ushort* ServerName, ushort* DnsDomainName, GUID* DomainGuid, GUID* DsaGuid, ushort* DnsHostName);

		[DllImport(@"netapi32", EntryPoint="NlBindingAddServerToCache", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int NlBindingAddServerToCache(ushort* UncServerName, NL_RPC_BINDING RpcBindingType);

		[DllImport(@"netapi32", EntryPoint="NetpGetComputerName", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetpGetComputerName(ushort** ComputerNamePtr);

		[DllImport(@"netapi32", EntryPoint="NetStatisticsGet", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetStatisticsGet(ushort* ServerName, ushort* Service, uint Level, uint Options, byte** Buffer);

		[DllImport(@"netapi32", EntryPoint="CredpValidateTargetName", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int CredpValidateTargetName(ushort* TargetName, uint Type, TARGET_NAME_TYPE TargetNameType, ushort** UserNamePointer, uint* PersistPointer, uint* TargetNameSize, WILDCARD_TYPE* WildcardTypePointer, UNICODE_STRING* NonWildcardedTargetName);

		[DllImport(@"netapi32", EntryPoint="NetpAddTlnFtinfoEntry", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe byte NetpAddTlnFtinfoEntry(NL_FTINFO_CONTEXT* FtinfoContext, UNICODE_STRING* Name);

		[DllImport(@"netapi32", EntryPoint="NetReplImportDirGetInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetReplImportDirGetInfo(ushort* UncServerName, uint Level, byte* Buf, uint* ParmError);

		[DllImport(@"netapi32", EntryPoint="RxNetUserPasswordSet", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint RxNetUserPasswordSet(ushort* ServerName, ushort* UserName, ushort* OldPassword, ushort* NewPassword);

		[DllImport(@"netapi32", EntryPoint="DsGetDcNameW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsGetDcNameW(ushort* ComputerName, ushort* DomainName, GUID* DomainGuid, ushort* SiteName, uint Flags, DOMAIN_CONTROLLER_INFOW** DomainControllerInfo);

		[DllImport(@"netapi32", EntryPoint="NetWkstaTransportAdd", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetWkstaTransportAdd(ushort* servername, uint level, byte* buf, uint* parm_err);

		[DllImport(@"netapi32", EntryPoint="NetMessageNameGetInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetMessageNameGetInfo(ushort* servername, ushort* msgname, uint level, byte** bufptr);

		[DllImport(@"netapi32", EntryPoint="NetLogonSetServiceBits", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int NetLogonSetServiceBits(ushort* ServerName, uint ServiceBitsOfInterest, uint ServiceBits);

		[DllImport(@"netapi32", EntryPoint="NetpGetConfigDword", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetpGetConfigDword(void* ConfigHandle, ushort* KeyWanted, uint DefaultValue, uint* ValueBuffer);

		[DllImport(@"netapi32", EntryPoint="NetWkstaTransportEnum", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetWkstaTransportEnum(ushort* servername, uint level, byte** bufptr, uint prefmaxlen, uint* entriesread, uint* totalentries, uint* resume_handle);

		[DllImport(@"netapi32", EntryPoint="NetReplExportDirEnum", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetReplExportDirEnum(ushort* UncServerName, uint Level, byte** BufPtr, uint PrefMaxSize, uint* EntriesRead, uint* TotalEntries, uint* ResumeHandle);

		[DllImport(@"netapi32", EntryPoint="NetAlertRaiseEx", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetAlertRaiseEx(ushort* AlertType, void* VariableInfo, uint VariableInfoSize, ushort* ServiceName);

		[DllImport(@"netapi32", EntryPoint="NetShareAdd", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetShareAdd(ushort* servername, uint level, byte* buf, uint* parm_err);

		[DllImport(@"netapi32", EntryPoint="NetSetPrimaryComputerName", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetSetPrimaryComputerName(ushort* Server, ushort* PrimaryName, ushort* DomainAccount, ushort* DomainAccountPassword, uint Reserved);

		[DllImport(@"netapi32", EntryPoint="NetDfsRemoveStdRoot", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetDfsRemoveStdRoot(ushort* ServerName, ushort* RootShare, uint Flags);

		[DllImport(@"netapi32", EntryPoint="DsGetDcNameA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsGetDcNameA(sbyte* ComputerName, sbyte* DomainName, GUID* DomainGuid, sbyte* SiteName, uint Flags, DOMAIN_CONTROLLER_INFOA** DomainControllerInfo);

		[DllImport(@"netapi32", EntryPoint="I_BrowserDebugCall", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_BrowserDebugCall(ushort* servername, uint DebugCode, uint Options);

		[DllImport(@"netapi32", EntryPoint="NetpIsUncComputerNameValid", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int NetpIsUncComputerNameValid(ushort* ComputerName);

		[DllImport(@"netapi32", EntryPoint="I_NetDfsManagerReportSiteInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_NetDfsManagerReportSiteInfo(ushort* ServerName, DFS_SITELIST_INFO** ppSiteInfo);

		[DllImport(@"netapi32", EntryPoint="NetGroupAdd", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetGroupAdd(ushort* ServerName, uint Level, byte* Buffer, uint* ParmError);

		[DllImport(@"netapi32", EntryPoint="NetpNetBiosGetAdapterNumbers", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetpNetBiosGetAdapterNumbers(LANA_ENUM* LanAdapterBuffer, ushort LanAdapterBufferSize);

		[DllImport(@"netapi32", EntryPoint="I_NetServerAuthenticate3", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int I_NetServerAuthenticate3(ushort* PrimaryName, ushort* AccountName, NETLOGON_SECURE_CHANNEL_TYPE AccountType, ushort* ComputerName, CYPHER_BLOCK* ClientCredential, CYPHER_BLOCK* ServerCredential, uint* NegotiatedFlags, uint* AccountRid);

		[DllImport(@"netapi32", EntryPoint="I_NetServerAuthenticate2", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int I_NetServerAuthenticate2(ushort* PrimaryName, ushort* AccountName, NETLOGON_SECURE_CHANNEL_TYPE AccountType, ushort* ComputerName, CYPHER_BLOCK* ClientCredential, CYPHER_BLOCK* ServerCredential, uint* NegotiatedFlags);

		[DllImport(@"netapi32", EntryPoint="I_NetLogonSamLogon", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int I_NetLogonSamLogon(ushort* LogonServer, ushort* ComputerName, NETLOGON_AUTHENTICATOR* Authenticator, NETLOGON_AUTHENTICATOR* ReturnAuthenticator, NETLOGON_LOGON_INFO_CLASS LogonLevel, byte* LogonInformation, NETLOGON_VALIDATION_INFO_CLASS ValidationLevel, byte** ValidationInformation, byte* Authoritative);

		[DllImport(@"netapi32", EntryPoint="NetpLocalTimeZoneOffset", CallingConvention=CallingConvention.StdCall)]
		public static extern int NetpLocalTimeZoneOffset();

		[DllImport(@"netapi32", EntryPoint="NetGetJoinableOUs", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetGetJoinableOUs(ushort* lpServer, ushort* lpDomain, ushort* lpAccount, ushort* lpPassword, uint* OUCount, ushort*** OUs);

		[DllImport(@"netapi32", EntryPoint="NetUseAdd", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetUseAdd(ushort* servername, uint level, byte* buf, uint* parm_err);

		[DllImport(@"netapi32", EntryPoint="RxNetServerEnum", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint RxNetServerEnum(ushort* UncServerName, ushort* TransportName, uint Level, byte** BufPtr, uint PrefMaxSize, uint* EntriesRead, uint* TotalEntries, uint ServerType, ushort* Domain, ushort* FirstNameToReturn);

		[DllImport(@"netapi32", EntryPoint="NetUserModalsGet", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetUserModalsGet(ushort* ServerName, uint Level, byte** Buffer);

		[DllImport(@"netapi32", EntryPoint="DsGetDcNextW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsGetDcNextW(void* GetDcContextHandle, uint* SockAddressCount, SOCKET_ADDRESS** SockAddresses, ushort** DnsHostName);

		[DllImport(@"netapi32", EntryPoint="NetUserDel", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetUserDel(ushort* ServerName, ushort* UserName);

		[DllImport(@"netapi32", EntryPoint="NetMessageBufferSend", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetMessageBufferSend(ushort* servername, ushort* msgname, ushort* fromname, byte* buf, uint buflen);

		[DllImport(@"netapi32", EntryPoint="RxRemoteApi", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint RxRemoteApi(uint ApiNumber, ushort* UncServerName, sbyte* ParmDescString, sbyte* DataDesc16, sbyte* DataDesc32, sbyte* DataDescSmb, sbyte* AuxDesc16, sbyte* AuxDesc32, sbyte* AuxDescSmb, uint Flags, ushort* TransportName);

		[DllImport(@"netapi32", EntryPoint="NetpGetFileSecurity", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetpGetFileSecurity(ushort* lpFileName, uint RequestedInformation, void** pSecurityDescriptor, uint* pnLength);

		[DllImport(@"netapi32", EntryPoint="NetpNetBiosSend", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetpNetBiosSend(byte LanAdapterNumber, byte SessionNumber, sbyte* SendBuffer, ushort SendBufferSize);

		[DllImport(@"netapi32", EntryPoint="NetUseGetInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetUseGetInfo(ushort* servername, ushort* usename, uint level, byte** bufptr);

		[DllImport(@"netapi32", EntryPoint="NetpGetDomainName", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetpGetDomainName(ushort** DomainNamePtr);

		[DllImport(@"netapi32", EntryPoint="DsRoleGetDcOperationResults", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsRoleGetDcOperationResults(ushort* lpServer, void* DsOperationHandle, DSROLE_SERVEROP_RESULTS** ServerOperationResults);

		[DllImport(@"netapi32", EntryPoint="NetDfsAddStdRoot", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetDfsAddStdRoot(ushort* ServerName, ushort* RootShare, ushort* Comment, uint Flags);

		[DllImport(@"netapi32", EntryPoint="DsGetDcNextA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsGetDcNextA(void* GetDcContextHandle, uint* SockAddressCount, SOCKET_ADDRESS** SockAddresses, sbyte** DnsHostName);

		[DllImport(@"netapi32", EntryPoint="NetServerGetInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetServerGetInfo(ushort* servername, uint level, byte** bufptr);

		[DllImport(@"netapi32", EntryPoint="NetAlertRaise", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetAlertRaise(ushort* AlertType, void* Buffer, uint BufferSize);

		[DllImport(@"netapi32", EntryPoint="NetServerSetInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetServerSetInfo(ushort* servername, uint level, byte* buf, uint* parm_err);

		[DllImport(@"netapi32", EntryPoint="I_NetDfsModifyPrefix", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_NetDfsModifyPrefix(ushort* servername, GUID* Uid, ushort* Prefix);

		[DllImport(@"netapi32", EntryPoint="NetUseDel", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetUseDel(ushort* servername, ushort* usename, uint ucond);

		[DllImport(@"netapi32", EntryPoint="NetpwNameCompare", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int NetpwNameCompare(ushort* Name1, ushort* Name2, uint NameType, uint Flags);

		[DllImport(@"netapi32", EntryPoint="NetErrorLogRead", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetErrorLogRead(ushort* UncServerName, ushort* Reserved1, HLOG* ErrorLogHandle, uint Offset, uint* Reserved2, uint Reserved3, uint OffsetFlag, byte** BufPtr, uint PrefMaxSize, uint* BytesRead, uint* TotalAvailable);

		[DllImport(@"netapi32", EntryPoint="NetWkstaUserSetInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetWkstaUserSetInfo(ushort* reserved, uint level, byte* buf, uint* parm_err);

		[DllImport(@"netapi32", EntryPoint="NetReplSetInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetReplSetInfo(ushort* UncServerName, uint Level, byte* Buf, uint* ParmError);

		[DllImport(@"netapi32", EntryPoint="I_NetDfsSetLocalVolumeState", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_NetDfsSetLocalVolumeState(ushort* servername, GUID* Uid, ushort* Prefix, uint State);

		[DllImport(@"netapi32", EntryPoint="NetReplExportDirUnlock", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetReplExportDirUnlock(ushort* UncServerName, ushort* DirName, uint UnlockForce);

		[DllImport(@"netapi32", EntryPoint="NetGetAnyDCName", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetGetAnyDCName(ushort* ServerName, ushort* DomainName, byte** Buffer);

		[DllImport(@"netapi32", EntryPoint="DsGetSiteNameW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsGetSiteNameW(ushort* ComputerName, ushort** SiteName);

		[DllImport(@"netapi32", EntryPoint="NetDfsAddStdRootForced", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetDfsAddStdRootForced(ushort* ServerName, ushort* RootShare, ushort* Comment, ushort* Share);

		[DllImport(@"netapi32", EntryPoint="DsValidateSubnetNameA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsValidateSubnetNameA(sbyte* SubnetName);

		[DllImport(@"netapi32", EntryPoint="NetLocalGroupSetInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetLocalGroupSetInfo(ushort* ServerName, ushort* LocalGroupName, uint Level, byte* Buffer, uint* ParmError);

		[DllImport(@"netapi32", EntryPoint="NetLocalGroupGetInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetLocalGroupGetInfo(ushort* ServerName, ushort* LocalGroupName, uint Level, byte** Buffer);

		[DllImport(@"netapi32", EntryPoint="NetFileGetInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetFileGetInfo(ushort* servername, uint fileid, uint level, byte** bufptr);

		[DllImport(@"netapi32", EntryPoint="NetShareDelSticky", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetShareDelSticky(ushort* servername, ushort* netname, uint reserved);

		[DllImport(@"netapi32", EntryPoint="NetGroupAddUser", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetGroupAddUser(ushort* ServerName, ushort* GroupName, ushort* UserName);

		[DllImport(@"netapi32", EntryPoint="NetpHexDump", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe void NetpHexDump(byte* Buffer, uint BufferSize);

		[DllImport(@"netapi32", EntryPoint="NetReplGetInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetReplGetInfo(ushort* UncServerName, ushort* DirName, uint UnlockForce);

		[DllImport(@"netapi32", EntryPoint="NetWkstaTransportDel", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetWkstaTransportDel(ushort* servername, ushort* transportname, uint ucond);

		[DllImport(@"netapi32", EntryPoint="NetpStoreIntialDcRecord", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetpStoreIntialDcRecord(DOMAIN_CONTROLLER_INFOW* DcInfo);

		[DllImport(@"netapi32", EntryPoint="NetWkstaSetInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetWkstaSetInfo(ushort* servername, uint level, byte* buf, uint* parm_err);

		[DllImport(@"netapi32", EntryPoint="NetpCloseConfigData", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetpCloseConfigData(void* ConfigHandle);

		[DllImport(@"netapi32", EntryPoint="NetpDbgPrint", CallingConvention=CallingConvention.StdCall)]
		public static extern void NetpDbgPrint();

		[DllImport(@"netapi32", EntryPoint="DsGetSiteNameA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsGetSiteNameA(sbyte* ComputerName, sbyte** SiteName);

		[DllImport(@"netapi32", EntryPoint="I_NetDfsDeleteExitPoint", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_NetDfsDeleteExitPoint(ushort* servername, GUID* Uid, ushort* Prefix, uint Type);

		[DllImport(@"netapi32", EntryPoint="DsRoleFreeMemory", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe void DsRoleFreeMemory(void* Address);

		[DllImport(@"netapi32", EntryPoint="NetpAccessCheckAndAudit", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetpAccessCheckAndAudit(ushort* SubsystemName, ushort* ObjectTypeName, void* SecurityDescriptor, uint DesiredAccess, GENERIC_MAPPING* GenericMapping);

		[DllImport(@"netapi32", EntryPoint="NetReplExportDirLock", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetReplExportDirLock(ushort* UncServerName, ushort* DirName);

		[DllImport(@"netapi32", EntryPoint="NetDfsManagerInitialize", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetDfsManagerInitialize(ushort* ServerName, uint Flags);

		[DllImport(@"netapi32", EntryPoint="NetpCreateSecurityObject", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int NetpCreateSecurityObject(ACE_DATA* AceData, uint AceCount, void* OwnerSid, void* GroupSid, GENERIC_MAPPING* GenericMapping, void** NewDescriptor);

		[DllImport(@"netapi32", EntryPoint="NetMessageNameAdd", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetMessageNameAdd(ushort* servername, ushort* msgname);

		[DllImport(@"netapi32", EntryPoint="NetLocalGroupDelMembers", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetLocalGroupDelMembers(ushort* ServerName, ushort* LocalGroupName, uint Level, byte* Buffer, uint NewMemberCount);

		[DllImport(@"netapi32", EntryPoint="I_NetPathCompare", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int I_NetPathCompare(ushort* ServerName, ushort* PathName1, ushort* PathName2, uint PathType, uint Flags);

		[DllImport(@"netapi32", EntryPoint="NetServerTransportEnum", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetServerTransportEnum(ushort* servername, uint level, byte** bufptr, uint prefmaxlen, uint* entriesread, uint* totalentries, uint* resume_handle);

		[DllImport(@"netapi32", EntryPoint="I_NetListCanonicalize", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_NetListCanonicalize(ushort* ServerName, ushort* List, ushort* Delimiters, ushort* Outbuf, uint OutbufLen, uint* OutCount, uint* PathTypes, uint PathTypesLen, uint Flags);

		[DllImport(@"netapi32", EntryPoint="NetRegisterDomainNameChangeNotification", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetRegisterDomainNameChangeNotification(void** NotificationEventHandle);

		[DllImport(@"netapi32", EntryPoint="I_NetServerReqChallenge", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int I_NetServerReqChallenge(ushort* PrimaryName, ushort* ComputerName, CYPHER_BLOCK* ClientChallenge, CYPHER_BLOCK* ServerChallenge);

		[DllImport(@"netapi32", EntryPoint="NetDfsMove", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetDfsMove(ushort* UncServerName, ushort* DirName);

		[DllImport(@"netapi32", EntryPoint="NetJoinDomain", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetJoinDomain(ushort* lpServer, ushort* lpDomain, ushort* lpMachineAccountOU, ushort* lpAccount, ushort* lpPassword, uint fJoinOptions);

		[DllImport(@"netapi32", EntryPoint="I_BrowserSetNetlogonState", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_BrowserSetNetlogonState(ushort* ServerName, ushort* DomainName, ushort* EmulatedComputerName, uint Role);

		[DllImport(@"netapi32", EntryPoint="NetDfsRemove", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetDfsRemove(ushort* DfsEntryPath, ushort* ServerName, ushort* ShareName);

		[DllImport(@"netapi32", EntryPoint="NetpOpenConfigData", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetpOpenConfigData(void** ConfigHandle, ushort* UncServerName, ushort* SectionName, int ReadOnly);

		[DllImport(@"netapi32", EntryPoint="NetapipBufferAllocate", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetapipBufferAllocate(uint ByteCount, void** Buffer);

		[DllImport(@"netapi32", EntryPoint="NetpIsRemote", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetpIsRemote(ushort* ComputerName, uint* LocalOrRemote, ushort* CanonicalizedName, uint Flags);

		[DllImport(@"netapi32", EntryPoint="DsAddressToSiteNamesA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsAddressToSiteNamesA(sbyte* ComputerName, uint EntryCount, SOCKET_ADDRESS* SocketAddresses, sbyte*** SiteNames);

		[DllImport(@"netapi32", EntryPoint="NetpNetBiosHangup", CallingConvention=CallingConvention.StdCall)]
		public static extern uint NetpNetBiosHangup(byte LanAdapterNumber, byte SessionNumber);

		[DllImport(@"netapi32", EntryPoint="NetpUpgradePreNT5JoinInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern uint NetpUpgradePreNT5JoinInfo();

		[DllImport(@"netapi32", EntryPoint="NetWkstaUserGetInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetWkstaUserGetInfo(ushort* reserved, uint level, byte** bufptr);

		[DllImport(@"netapi32", EntryPoint="DsRoleDemoteDc", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsRoleDemoteDc(ushort* lpServer, ushort* lpDnsDomainName, DSROLE_SERVEROP_DEMOTE_ROLE ServerRole, ushort* lpAccount, ushort* lpPassword, uint Options, int fLastDcInDomain, ushort* lpAdminPassword, void** DsOperationHandle);

		[DllImport(@"netapi32", EntryPoint="NetpCleanFtinfoContext", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe void NetpCleanFtinfoContext(NL_FTINFO_CONTEXT* FtinfoContext);

		[DllImport(@"netapi32", EntryPoint="DsRoleGetPrimaryDomainInformation", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsRoleGetPrimaryDomainInformation(ushort* lpServer, DSROLE_PRIMARY_DOMAIN_INFO_LEVEL InfoLevel, byte** Buffer);

		[DllImport(@"netapi32", EntryPoint="NetpwNameValidate", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetpwNameValidate(ushort* Name, uint NameType, uint Flags);

		[DllImport(@"netapi32", EntryPoint="NetDfsGetClientInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetDfsGetClientInfo(ushort* DfsEntryPath, ushort* ServerName, ushort* ShareName, uint Level, byte** Buffer);

		[DllImport(@"netapi32", EntryPoint="NetServerComputerNameDel", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetServerComputerNameDel(ushort* ServerName, ushort* EmulatedServerName);

		[DllImport(@"netapi32", EntryPoint="NetReplImportDirEnum", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetReplImportDirEnum(ushort* UncServerName, uint Level, byte** BufPtr, uint PrefMaxSize, uint* EntriesRead, uint* TotalEntries, uint* ResumeHandle);

		[DllImport(@"netapi32", EntryPoint="NetShareEnumSticky", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetShareEnumSticky(ushort* servername, uint level, byte** bufptr, uint prefmaxlen, uint* entriesread, uint* totalentries, uint* resume_handle);

		[DllImport(@"netapi32", EntryPoint="NlBindingSetAuthInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int NlBindingSetAuthInfo(ushort* UncServerName, NL_RPC_BINDING RpcBindingType, int SealIt, void* ClientContext, ushort* ServerContext);

		[DllImport(@"netapi32", EntryPoint="NetLocalGroupGetMembers", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetLocalGroupGetMembers(ushort* ServerName, ushort* LocalGroupName, uint Level, byte** Buffer, uint PrefMaxLen, uint* EntriesRead, uint* EntriesLeft, uint* ResumeHandle);

		[DllImport(@"netapi32", EntryPoint="I_BrowserServerEnum", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_BrowserServerEnum(ushort* servername, ushort* transport, ushort* clientname, uint level, byte** bufptr, uint prefmaxlen, uint* entriesread, uint* totalentries, uint servertype, ushort* domain, uint* resume_handle);

		[DllImport(@"netapi32", EntryPoint="NetDfsGetDcAddress", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetDfsGetDcAddress(ushort* ServerName, ushort** DcName, byte* IsRoot, uint* Timeout);

		[DllImport(@"netapi32", EntryPoint="I_NetServerTrustPasswordsGet", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int I_NetServerTrustPasswordsGet(ushort* TrustedDcName, ushort* AccountName, NETLOGON_SECURE_CHANNEL_TYPE AccountType, ushort* ComputerName, NETLOGON_AUTHENTICATOR* Authenticator, NETLOGON_AUTHENTICATOR* ReturnAuthenticator, ENCRYPTED_LM_OWF_PASSWORD* EncryptedNewOwfPassword, ENCRYPTED_LM_OWF_PASSWORD* EncryptedOldOwfPassword);

		[DllImport(@"netapi32", EntryPoint="NetConnectionEnum", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetConnectionEnum(ushort* servername, ushort* qualifier, uint level, byte** bufptr, uint prefmaxlen, uint* entriesread, uint* totalentries, uint* resume_handle);

		[DllImport(@"netapi32", EntryPoint="DsGetDcSiteCoverageW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsGetDcSiteCoverageW(ushort* ComputerName, uint* EntryCount, ushort*** SiteNames);

		[DllImport(@"netapi32", EntryPoint="NetQueryDisplayInformation", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetQueryDisplayInformation(ushort* ServerName, uint Level, uint Index, uint EntriesRequested, uint PreferredMaximumLength, uint* ReturnedEntryCount, void** SortedBuffer);

		[DllImport(@"netapi32", EntryPoint="NetpAccessCheck", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetpAccessCheck(void* SecurityDescriptor, uint DesiredAccess, GENERIC_MAPPING* GenericMapping);

		[DllImport(@"netapi32", EntryPoint="NetReplImportDirLock", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetReplImportDirLock(ushort* UncServerName, ushort* DirName);

		[DllImport(@"netapi32", EntryPoint="NetAuditClear", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetAuditClear(ushort* UncServerName, ushort* backupfile, ushort* reserved);

		[DllImport(@"netapi32", EntryPoint="NetWkstaGetInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetWkstaGetInfo(ushort* servername, uint level, byte** bufptr);

		[DllImport(@"netapi32", EntryPoint="NetDfsManagerSendSiteInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetDfsManagerSendSiteInfo(ushort* wszServer, ushort* wszLocalVolumeEntryPath, DFS_SITELIST_INFO* pSiteInfo);

		[DllImport(@"netapi32", EntryPoint="NetpAllocStrFromWStr", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe sbyte* NetpAllocStrFromWStr(ushort* Unicode);

		[DllImport(@"netapi32", EntryPoint="DsGetDcSiteCoverageA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsGetDcSiteCoverageA(sbyte* ComputerName, uint* EntryCount, sbyte*** SiteNames);

		[DllImport(@"netapi32", EntryPoint="DsRoleGetDatabaseFacts", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsRoleGetDatabaseFacts(ushort* lpServer, ushort* lpRestorePath, ushort** lpDNSDomainName, uint* State);

		[DllImport(@"netapi32", EntryPoint="NetAddAlternateComputerName", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetAddAlternateComputerName(ushort* Server, ushort* AlternateName, ushort* DomainAccount, ushort* DomainAccountPassword, uint Reserved);

		[DllImport(@"netapi32", EntryPoint="DsValidateSubnetNameW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsValidateSubnetNameW(ushort* SubnetName);

		[DllImport(@"netapi32", EntryPoint="DsRoleUpgradeDownlevelServer", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsRoleUpgradeDownlevelServer(ushort* lpDnsDomainName, ushort* lpSiteName, ushort* lpDsDatabasePath, ushort* lpDsLogPath, ushort* lpSystemVolumeRootPath, ushort* lpParentDnsDomainName, ushort* lpParentServer, ushort* lpAccount, ushort* lpPassword, ushort* lpDsRepairPassword, uint Options, void** DsOperationHandle);

		[DllImport(@"netapi32", EntryPoint="NetpwPathType", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetpwPathType(ushort* PathName, uint* PathType, uint Flags);

		[DllImport(@"netapi32", EntryPoint="NetpPackString", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetpPackString(ushort** @string, byte* dataend, ushort** laststring);

		[DllImport(@"netapi32", EntryPoint="DsEnumerateDomainTrustsW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsEnumerateDomainTrustsW(ushort* ServerName, uint Flags, DS_DOMAIN_TRUSTSW** Domains, uint* DomainCount);

		[DllImport(@"netapi32", EntryPoint="NetUserGetLocalGroups", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetUserGetLocalGroups(ushort* ServerName, ushort* UserName, uint Level, uint Flags, byte** Buffer, uint PrefMaxLen, uint* EntriesRead, uint* EntriesLeft);

		[DllImport(@"netapi32", EntryPoint="NetLocalGroupDelMember", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetLocalGroupDelMember(ushort* ServerName, ushort* LocalGroupName, void* MemberSid);

		[DllImport(@"netapi32", EntryPoint="RxNetAccessSetInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint RxNetAccessSetInfo(ushort* ServerName, ushort* ResourceName, uint Level, byte* Buffer, uint* ParmError);

		[DllImport(@"netapi32", EntryPoint="NetServerTransportDel", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetServerTransportDel(ushort* servername, uint level, byte* bufptr);

		[DllImport(@"netapi32", EntryPoint="NetShareSetInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetShareSetInfo(ushort* servername, ushort* netname, uint level, byte* buf, uint* parm_err);

		[DllImport(@"netapi32", EntryPoint="I_NetNameValidate", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_NetNameValidate(ushort* ServerName, ushort* Name, uint NameType, uint Flags);

		[DllImport(@"netapi32", EntryPoint="NetMessageNameDel", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetMessageNameDel(ushort* servername, ushort* msgname);

		[DllImport(@"netapi32", EntryPoint="I_NetDfsDeleteLocalPartition", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_NetDfsDeleteLocalPartition(ushort* servername, GUID* Uid, ushort* Prefix);

		[DllImport(@"netapi32", EntryPoint="RxNetAccessDel", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint RxNetAccessDel(ushort* ServerName, ushort* ResourceName);

		[DllImport(@"netapi32", EntryPoint="NetServerTransportAdd", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetServerTransportAdd(ushort* servername, uint level, byte* bufptr);

		[DllImport(@"netapi32", EntryPoint="NetEnumerateTrustedDomains", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int NetEnumerateTrustedDomains(ushort* ServerName, ushort** DomainNames);

		[DllImport(@"netapi32", EntryPoint="NetpNetBiosStatusToApiStatus", CallingConvention=CallingConvention.StdCall)]
		public static extern uint NetpNetBiosStatusToApiStatus(byte NetBiosStatus);

		[DllImport(@"netapi32", EntryPoint="DsEnumerateDomainTrustsA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsEnumerateDomainTrustsA(sbyte* ServerName, uint Flags, DS_DOMAIN_TRUSTSA** Domains, uint* DomainCount);

		[DllImport(@"netapi32", EntryPoint="NetpInitOemString", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe void NetpInitOemString(STRING* DestinationString, sbyte* SourceString);

		[DllImport(@"netapi32", EntryPoint="NetAuditWrite", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetAuditWrite(ushort* UncServerName, ushort* DirName, uint Level, byte* Buf, uint* ParmError);

		[DllImport(@"netapi32", EntryPoint="I_NetLogonSamLogoff", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int I_NetLogonSamLogoff(ushort* LogonServer, ushort* ComputerName, NETLOGON_AUTHENTICATOR* Authenticator, NETLOGON_AUTHENTICATOR* ReturnAuthenticator, NETLOGON_LOGON_INFO_CLASS LogonLevel, byte* LogonInformation);

		[DllImport(@"netapi32", EntryPoint="DsRoleCancel", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsRoleCancel(ushort* lpServer, void* DsOperationHandle);

		[DllImport(@"netapi32", EntryPoint="I_NetNameCompare", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int I_NetNameCompare(ushort* ServerName, ushort* Name1, ushort* Name2, uint NameType, uint Flags);

		[DllImport(@"netapi32", EntryPoint="NetServiceGetInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetServiceGetInfo(ushort* servername, ushort* service, uint level, byte** bufptr);

		[DllImport(@"netapi32", EntryPoint="NetShareCheck", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetShareCheck(ushort* servername, ushort* device, uint* type);

		[DllImport(@"netapi32", EntryPoint="NetServerDiskEnum", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetServerDiskEnum(ushort* servername, uint level, byte** bufptr, uint prefmaxlen, uint* entriesread, uint* totalentries, uint* resume_handle);

		[DllImport(@"netapi32", EntryPoint="NetpDeleteSecurityObject", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int NetpDeleteSecurityObject(void** Descriptor);

		[DllImport(@"netapi32", EntryPoint="NetLocalGroupAdd", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetLocalGroupAdd(ushort* ServerName, uint Level, byte* Buffer, uint* ParmError);

		[DllImport(@"netapi32", EntryPoint="I_NetNameCanonicalize", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_NetNameCanonicalize(ushort* ServerName, ushort* Name, ushort* Outbuf, uint OutbufLen, uint NameType, uint Flags);

		[DllImport(@"netapi32", EntryPoint="DsRoleAbortDownlevelServerUpgrade", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsRoleAbortDownlevelServerUpgrade(ushort* lpAdminPassword, ushort* lpAccount, ushort* lpPassword, uint Options);

		[DllImport(@"netapi32", EntryPoint="NetpReleasePrivilege", CallingConvention=CallingConvention.StdCall)]
		public static extern uint NetpReleasePrivilege();

		[DllImport(@"netapi32", EntryPoint="NetUserChangePassword", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetUserChangePassword(ushort* DomainName, ushort* UserName, ushort* OldPassword, ushort* NewPassword);

		[DllImport(@"netapi32", EntryPoint="I_NetlogonComputeServerDigest", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_NetlogonComputeServerDigest(ushort* ServerName, uint Rid, byte* Message, uint MessageSize, sbyte* NewMessageDigest, sbyte* OldMessageDigest);

		[DllImport(@"netapi32", EntryPoint="NetpNetBiosReceive", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetpNetBiosReceive(byte LanAdapterNumber, byte SessionNumber, byte* ReceiveBuffer, ushort ReceiveBufferSize, void* EventHandle, ushort* NumberOfBytesReceived);

		[DllImport(@"netapi32", EntryPoint="I_NetLogonGetDomainInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int I_NetLogonGetDomainInfo(ushort* ServerName, ushort* ComputerName, NETLOGON_AUTHENTICATOR* Authenticator, NETLOGON_AUTHENTICATOR* ReturnAuthenticator, uint QueryLevel, byte* InBuffer, byte** OutBuffer);

		[DllImport(@"netapi32", EntryPoint="NetLocalGroupSetMembers", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetLocalGroupSetMembers(ushort* ServerName, ushort* LocalGroupName, uint Level, byte* Buffer, uint NewMemberCount);

		[DllImport(@"netapi32", EntryPoint="NetReplImportDirDel", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetReplImportDirDel(ushort* UncServerName, ushort* DirName);

		[DllImport(@"netapi32", EntryPoint="NetDfsSetClientInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetDfsSetClientInfo(ushort* DfsEntryPath, ushort* ServerName, ushort* ShareName, uint Level, byte* Buffer);

		[DllImport(@"netapi32", EntryPoint="DsRoleGetDcOperationProgress", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsRoleGetDcOperationProgress(ushort* lpServer, void* DsOperationHandle, DSROLE_SERVEROP_STATUS** ServerOperationStatus);

		[DllImport(@"netapi32", EntryPoint="NetDfsSetInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetDfsSetInfo(ushort* DfsEntryPath, ushort* ServerName, ushort* ShareName, uint Level, byte* Buffer);

		[DllImport(@"netapi32", EntryPoint="NetDfsGetInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetDfsGetInfo(ushort* DfsEntryPath, ushort* ServerName, ushort* ShareName, uint Level, byte** Buffer);

		[DllImport(@"netapi32", EntryPoint="I_NetServerPasswordSet", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int I_NetServerPasswordSet(ushort* PrimaryName, ushort* AccountName, NETLOGON_SECURE_CHANNEL_TYPE AccountType, ushort* ComputerName, NETLOGON_AUTHENTICATOR* Authenticator, NETLOGON_AUTHENTICATOR* ReturnAuthenticator, ENCRYPTED_LM_OWF_PASSWORD* UasNewPassword);

		[DllImport(@"netapi32", EntryPoint="I_NetListTraverse", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe ushort* I_NetListTraverse(ushort* Reserved, ushort** pList, uint Flags);

		[DllImport(@"netapi32", EntryPoint="I_NetServerSetServiceBitsEx", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_NetServerSetServiceBitsEx(ushort* ServerName, ushort* EmulatedServerName, ushort* TransportName, uint ServiceBitsOfInterest, uint ServiceBits, uint UpdateImmediately);

		[DllImport(@"netapi32", EntryPoint="NetpParmsSetUserProperty", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int NetpParmsSetUserProperty(ushort* UserParms, ushort* Property, UNICODE_STRING PropertyValue, ushort PropertyFlag, ushort** pNewUserParms, int* Update);

		[DllImport(@"netapi32", EntryPoint="NetScheduleJobGetInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetScheduleJobGetInfo(ushort* ServerName, uint JobId, byte** PointerToBuffer);

		[DllImport(@"netapi32", EntryPoint="I_NetDfsSetServerInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_NetDfsSetServerInfo(ushort* servername, GUID* Uid, ushort* Prefix);

		[DllImport(@"netapi32", EntryPoint="NetpSetFileSecurity", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetpSetFileSecurity(ushort* lpFileName, uint SecurityInformation, void* pSecurityDescriptor);

		[DllImport(@"netapi32", EntryPoint="NetpTStrArrayEntryCount", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetpTStrArrayEntryCount(ushort* Array);

		[DllImport(@"netapi32", EntryPoint="NetpSmbCheck", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int NetpSmbCheck(byte* buffer, ushort size, byte func, int parms, sbyte* fields);

		[DllImport(@"netapi32", EntryPoint="NetDfsRemoveFtRoot", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetDfsRemoveFtRoot(ushort* ServerName, ushort* RootShare, ushort* FtDfsName, uint Flags);

		[DllImport(@"netapi32", EntryPoint="NetSessionEnum", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetSessionEnum(ushort* servername, ushort* clientname, ushort* username, uint level, byte** bufptr, uint prefmaxlen, uint* entriesread, uint* totalentries, uint* resume_handle);

		[DllImport(@"netapi32", EntryPoint="NetScheduleJobAdd", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetScheduleJobAdd(ushort* ServerName, byte* Buffer, uint* pJobId);

		[DllImport(@"netapi32", EntryPoint="NetUseEnum", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetUseEnum(ushort* servername, uint level, byte** bufptr, uint prefmaxlen, uint* entriesread, uint* totalentries, uint* resume_handle);

		[DllImport(@"netapi32", EntryPoint="NetRemoveAlternateComputerName", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetRemoveAlternateComputerName(ushort* Server, ushort* AlternateName, ushort* DomainAccount, ushort* DomainAccountPassword, uint Reserved);

		[DllImport(@"netapi32", EntryPoint="NetUserAdd", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetUserAdd(ushort* ServerName, uint Level, byte* Buffer, uint* ParmError);

		[DllImport(@"netapi32", EntryPoint="NetGroupEnum", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetGroupEnum(ushort* ServerName, uint Level, byte** Buffer, uint PrefMaxLen, uint* EntriesRead, uint* EntriesLeft, uint* ResumeHandle);

		[DllImport(@"netapi32", EntryPoint="NetpwPathCompare", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int NetpwPathCompare(ushort* PathName1, ushort* PathName2, uint PathType, uint Flags);

		[DllImport(@"netapi32", EntryPoint="NetpNetBiosAddName", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetpNetBiosAddName(sbyte* NetBiosName, byte LanAdapterNumber, byte* NetBiosNameNumber);

		[DllImport(@"netapi32", EntryPoint="DsGetDcCloseW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe void DsGetDcCloseW(void* GetDcContextHandle);

		[DllImport(@"netapi32", EntryPoint="I_NetDfsGetFtServers", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_NetDfsGetFtServers(void* LdapInputArg, ushort* wszDomainName, ushort* wszDfsName, ushort*** List);

		[DllImport(@"netapi32", EntryPoint="NetUnregisterDomainNameChangeNotification", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetUnregisterDomainNameChangeNotification(void* NotificationEventHandle);

		[DllImport(@"netapi32", EntryPoint="NetServerEnumEx", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetServerEnumEx(ushort* servername, uint level, byte** bufptr, uint prefmaxlen, uint* entriesread, uint* totalentries, uint servertype, ushort* domain, ushort* FirstNameToReturnArg);

		[DllImport(@"netapi32", EntryPoint="I_NetLogonUasLogoff", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_NetLogonUasLogoff(ushort* UserName, ushort* Workstation, NETLOGON_LOGOFF_UAS_INFO* LogoffInformation);

		[DllImport(@"netapi32", EntryPoint="NetpNetBiosDelName", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetpNetBiosDelName(sbyte* NetBiosName, byte LanAdapterNumber);

		[DllImport(@"netapi32", EntryPoint="NetApiBufferSize", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetApiBufferSize(void* Buffer, uint* ByteCount);

		[DllImport(@"netapi32", EntryPoint="NetConfigGetAll", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetConfigGetAll(ushort* UncServerName, ushort* Component, byte** BufPtr);

		[DllImport(@"netapi32", EntryPoint="NetpCopyStringToBuffer", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int NetpCopyStringToBuffer(ushort* String, uint CharacterCount, byte* FixedDataEnd, ushort** EndOfVariableData, ushort** VariableDataPointer);

		[DllImport(@"netapi32", EntryPoint="DsAddressToSiteNamesW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsAddressToSiteNamesW(ushort* ComputerName, uint EntryCount, SOCKET_ADDRESS* SocketAddresses, ushort*** SiteNames);

		[DllImport(@"netapi32", EntryPoint="NetpParmsSetUserPropertyWithLength", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int NetpParmsSetUserPropertyWithLength(UNICODE_STRING* UserParms, ushort* Property, UNICODE_STRING PropertyValue, ushort PropertyFlag, ushort** pNewUserParms, int* Update);

		[DllImport(@"netapi32", EntryPoint="DsAddressToSiteNamesExA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsAddressToSiteNamesExA(sbyte* ComputerName, uint EntryCount, SOCKET_ADDRESS* SocketAddresses, sbyte*** SiteNames, sbyte*** SubnetNames);

		[DllImport(@"netapi32", EntryPoint="DsRoleServerSaveStateForUpgrade", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsRoleServerSaveStateForUpgrade(ushort* lpAnswerFile);

		[DllImport(@"netapi32", EntryPoint="NetServiceControl", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetServiceControl(ushort* servername, ushort* service, uint opcode, uint arg, byte** bufptr);

		[DllImport(@"netapi32", EntryPoint="DsGetDcNameWithAccountA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsGetDcNameWithAccountA(sbyte* ComputerName, sbyte* AccountName, uint AllowableAccountControlBits, sbyte* DomainName, GUID* DomainGuid, sbyte* SiteName, uint Flags, DOMAIN_CONTROLLER_INFOA** DomainControllerInfo);

		[DllImport(@"netapi32", EntryPoint="I_NetPathCanonicalize", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_NetPathCanonicalize(ushort* ServerName, ushort* PathName, ushort* Outbuf, uint OutbufLen, ushort* Prefix, uint* PathType, uint Flags);

		[DllImport(@"netapi32", EntryPoint="NetReplExportDirSetInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetReplExportDirSetInfo(ushort* UncServerName, ushort* DirName, uint Level, byte* Buf, uint* ParmError);

		[DllImport(@"netapi32", EntryPoint="NetConfigGet", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetConfigGet(ushort* UncServerName, ushort* Component, ushort* Parameter, byte** BufPtr);

		[DllImport(@"netapi32", EntryPoint="NetReplExportDirGetInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetReplExportDirGetInfo(ushort* UncServerName, uint Level, byte* Buf, uint* ParmError);

		[DllImport(@"netapi32", EntryPoint="NetpGetPrivilege", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetpGetPrivilege(uint numPrivileges, uint* pulPrivileges);

		[DllImport(@"netapi32", EntryPoint="DsGetForestTrustInformationW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsGetForestTrustInformationW(ushort* ServerName, ushort* TrustedDomainName, uint Flags, LSA_FOREST_TRUST_INFORMATION** ForestTrustInfo);

		[DllImport(@"netapi32", EntryPoint="I_NetDfsFixLocalVolume", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_NetDfsFixLocalVolume(ushort* servername, ushort* VolumeName, uint EntryType, uint ServiceType, ushort* StgId, GUID* EntryUid, ushort* EntryPrefix, NET_DFS_ENTRY_ID_CONTAINER* RelationInfo, uint CreateDisposition);

		[DllImport(@"netapi32", EntryPoint="I_NetAccountSync", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_NetAccountSync(ushort* PrimaryName, ushort* ComputerName, NETLOGON_AUTHENTICATOR* Authenticator, NETLOGON_AUTHENTICATOR* ReturnAuthenticator, uint Reference, uint Level, byte* Buffer, uint BufferSize, uint* CountReturned, uint* TotalEntries, uint* NextReference, UAS_INFO_0* LastRecordId);

		[DllImport(@"netapi32", EntryPoint="I_NetDatabaseDeltas", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int I_NetDatabaseDeltas(ushort* PrimaryName, ushort* ComputerName, NETLOGON_AUTHENTICATOR* Authenticator, NETLOGON_AUTHENTICATOR* ReturnAuthenticator, uint DatabaseID, NLPR_MODIFIED_COUNT* DomainModifiedCount, NETLOGON_DELTA_ENUM_ARRAY** DeltaArray, uint PreferredMaximumLength);

		[DllImport(@"netapi32", EntryPoint="Netbios", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe byte Netbios(NCB* pncb);

		[DllImport(@"netapi32", EntryPoint="NetShareEnum", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetShareEnum(ushort* servername, uint level, byte** bufptr, uint prefmaxlen, uint* entriesread, uint* totalentries, uint* resume_handle);

		[DllImport(@"netapi32", EntryPoint="DsAddressToSiteNamesExW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsAddressToSiteNamesExW(ushort* ComputerName, uint EntryCount, SOCKET_ADDRESS* SocketAddresses, ushort*** SiteNames, ushort*** SubnetNames);

		[DllImport(@"netapi32", EntryPoint="NetpApiStatusToNtStatus", CallingConvention=CallingConvention.StdCall)]
		public static extern int NetpApiStatusToNtStatus(uint NetStatus);

		[DllImport(@"netapi32", EntryPoint="DsRoleDcAsDc", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsRoleDcAsDc(ushort* lpServer, ushort* lpDnsDomainName, ushort* lpFlatDomainName, ushort* lpDomainAdminPassword, ushort* lpSiteName, ushort* lpDsDatabasePath, ushort* lpDsLogPath, ushort* lpSystemVolumeRootPath, ushort* lpParentDnsDomainName, ushort* lpParentServer, ushort* lpAccount, ushort* lpPassword, ushort* lpDsRepairPassword, uint Options, void** DsOperationHandle);

		[DllImport(@"netapi32", EntryPoint="I_NetGetDCList", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_NetGetDCList(ushort* ServerName, ushort* TrustedDomainName, uint* DCCount, UNICODE_STRING** DCNames);

		[DllImport(@"netapi32", EntryPoint="NetDfsAdd", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetDfsAdd(ushort* DfsEntryPath, ushort* ServerName, ushort* ShareName, ushort* Comment, uint Flags);

		[DllImport(@"netapi32", EntryPoint="RxNetAccessGetInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint RxNetAccessGetInfo(ushort* ServerName, ushort* ResourceName, uint Level, byte** Buffer);

		[DllImport(@"netapi32", EntryPoint="I_BrowserDebugTrace", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_BrowserDebugTrace(ushort* servername, sbyte* DebugString);

		[DllImport(@"netapi32", EntryPoint="NetMessageNameEnum", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetMessageNameEnum(ushort* servername, uint level, byte** bufptr, uint prefmaxlen, uint* entriesread, uint* totalentries, uint* resume_handle);

		[DllImport(@"netapi32", EntryPoint="DsRoleDcAsReplica", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsRoleDcAsReplica(ushort* lpServer, ushort* lpDnsDomainName, ushort* lpReplicaServer, ushort* lpSiteName, ushort* lpDsDatabasePath, ushort* lpDsLogPath, ushort* lpRestorePath, ushort* lpSystemVolumeRootPath, ushort* lpBootkey, ushort* lpAccount, ushort* lpPassword, ushort* lpDsRepairPassword, uint Options, void** DsOperationHandle);

		[DllImport(@"netapi32", EntryPoint="NetpAllocFtinfoEntry", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe byte NetpAllocFtinfoEntry(NL_FTINFO_CONTEXT* FtinfoContext, LSA_FOREST_TRUST_RECORD_TYPE ForestTrustType, UNICODE_STRING* Name, void* Sid, UNICODE_STRING* NetbiosName);

		[DllImport(@"netapi32", EntryPoint="NetBrowserStatisticsGet", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint NetBrowserStatisticsGet(ushort* ServerName, uint Level, byte** Buffer);

		[DllImport(@"netapi32", EntryPoint="I_NetGetForestTrustInformation", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int I_NetGetForestTrustInformation(ushort* ServerName, ushort* ComputerName, NETLOGON_AUTHENTICATOR* Authenticator, NETLOGON_AUTHENTICATOR* ReturnAuthenticator, uint Flags, LSA_FOREST_TRUST_INFORMATION** ForestTrustInfo);

		[DllImport(@"netapi32", EntryPoint="I_NetServerSetServiceBits", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint I_NetServerSetServiceBits(ushort* servername, ushort* transportname, uint servicebits, uint updateimmediately);

	}

	#region structs (65)

	[StructLayout(LayoutKind.Explicit, Size=28)]
	public struct NLPR_QUOTA_LIMITS
	{
		[FieldOffset(0)]
		public uint PagedPoolLimit;

		[FieldOffset(4)]
		public uint NonPagedPoolLimit;

		[FieldOffset(8)]
		public uint MinimumWorkingSetSize;

		[FieldOffset(12)]
		public uint MaximumWorkingSetSize;

		[FieldOffset(16)]
		public uint PagefileLimit;

		[FieldOffset(20)]
		public OLD_LARGE_INTEGER TimeLimit;
	}

	[StructLayout(LayoutKind.Explicit, Size=24)]
	public struct UAS_INFO_0
	{
		//Fixed-length Array "ComputerName[16]". Members can be
		//accessed with (&my_UAS_INFO_0.ComputerName_16)[index]
		[FieldOffset(0)]
		public sbyte ComputerName_16;

		[FieldOffset(16)]
		public uint TimeCreated;

		[FieldOffset(20)]
		public uint SerialNumber;
	}

	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct UNICODE_STRING
	{
		[FieldOffset(0)]
		public ushort Length;

		[FieldOffset(2)]
		public ushort MaximumLength;

		[FieldOffset(4)]
		public unsafe ushort* Buffer;
	}

	[StructLayout(LayoutKind.Explicit, Size=12)]
	public struct ISID
	{
		[FieldOffset(0)]
		public byte Revision;

		[FieldOffset(1)]
		public byte SubAuthorityCount;

		[FieldOffset(2)]
		public SID_IDENTIFIER_AUTHORITY IdentifierAuthority;

		//Fixed-length Array "SubAuthority[1]". Members can be
		//accessed with (&my_ISID.SubAuthority_1)[index]
		[FieldOffset(8)]
		public uint SubAuthority_1;
	}

	[StructLayout(LayoutKind.Explicit, Size=72)]
	public struct NETLOGON_DELTA_ALIAS
	{
		[FieldOffset(0)]
		public UNICODE_STRING Name;

		[FieldOffset(8)]
		public uint RelativeId;

		[FieldOffset(12)]
		public uint SecurityInformation;

		[FieldOffset(16)]
		public uint SecuritySize;

		[FieldOffset(20)]
		public unsafe byte* SecurityDescriptor;

		[FieldOffset(24)]
		public UNICODE_STRING DummyString1;

		[FieldOffset(32)]
		public UNICODE_STRING DummyString2;

		[FieldOffset(40)]
		public UNICODE_STRING DummyString3;

		[FieldOffset(48)]
		public UNICODE_STRING DummyString4;

		[FieldOffset(56)]
		public uint DummyLong1;

		[FieldOffset(60)]
		public uint DummyLong2;

		[FieldOffset(64)]
		public uint DummyLong3;

		[FieldOffset(68)]
		public uint DummyLong4;
	}

	[StructLayout(LayoutKind.Explicit, Size=120)]
	public struct NETLOGON_DELTA_DOMAIN
	{
		[FieldOffset(0)]
		public UNICODE_STRING DomainName;

		[FieldOffset(8)]
		public UNICODE_STRING OemInformation;

		[FieldOffset(16)]
		public OLD_LARGE_INTEGER ForceLogoff;

		[FieldOffset(24)]
		public ushort MinPasswordLength;

		[FieldOffset(26)]
		public ushort PasswordHistoryLength;

		[FieldOffset(28)]
		public OLD_LARGE_INTEGER MaxPasswordAge;

		[FieldOffset(36)]
		public OLD_LARGE_INTEGER MinPasswordAge;

		[FieldOffset(44)]
		public OLD_LARGE_INTEGER DomainModifiedCount;

		[FieldOffset(52)]
		public OLD_LARGE_INTEGER DomainCreationTime;

		[FieldOffset(60)]
		public uint SecurityInformation;

		[FieldOffset(64)]
		public uint SecuritySize;

		[FieldOffset(68)]
		public unsafe byte* SecurityDescriptor;

		[FieldOffset(72)]
		public UNICODE_STRING DummyString1;

		[FieldOffset(80)]
		public UNICODE_STRING DummyString2;

		[FieldOffset(88)]
		public UNICODE_STRING DummyString3;

		[FieldOffset(96)]
		public UNICODE_STRING DummyString4;

		[FieldOffset(104)]
		public uint DummyLong1;

		[FieldOffset(108)]
		public uint DummyLong2;

		[FieldOffset(112)]
		public uint DummyLong3;

		[FieldOffset(116)]
		public uint DummyLong4;
	}

	[StructLayout(LayoutKind.Explicit, Size=4)]
	public struct NETLOGON_DELTA_ID_UNION
	{
		[FieldOffset(0)]
		public uint Rid;

		[FieldOffset(0)]
		public unsafe ISID* Sid;

		[FieldOffset(0)]
		public unsafe ushort* Name;
	}

	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct NETLOGON_LOGOFF_UAS_INFO
	{
		[FieldOffset(0)]
		public uint Duration;

		[FieldOffset(4)]
		public ushort LogonCount;
	}

	[StructLayout(LayoutKind.Explicit, Size=48)]
	public struct DOMAIN_CONTROLLER_INFOA
	{
		[FieldOffset(0)]
		public unsafe sbyte* DomainControllerName;

		[FieldOffset(4)]
		public unsafe sbyte* DomainControllerAddress;

		[FieldOffset(8)]
		public uint DomainControllerAddressType;

		[FieldOffset(12)]
		public GUID DomainGuid;

		[FieldOffset(28)]
		public unsafe sbyte* DomainName;

		[FieldOffset(32)]
		public unsafe sbyte* DnsForestName;

		[FieldOffset(36)]
		public uint Flags;

		[FieldOffset(40)]
		public unsafe sbyte* DcSiteName;

		[FieldOffset(44)]
		public unsafe sbyte* ClientSiteName;
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

	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct DFS_SITENAME_INFO
	{
		[FieldOffset(0)]
		public uint SiteFlags;

		[FieldOffset(4)]
		public unsafe ushort* SiteName;
	}

	[StructLayout(LayoutKind.Explicit, Size=16)]
	public struct NL_FTINFO_CONTEXT
	{
		[FieldOffset(0)]
		public LIST_ENTRY FtinfoList;

		[FieldOffset(8)]
		public uint FtinfoSize;

		[FieldOffset(12)]
		public uint FtinfoCount;
	}

	[StructLayout(LayoutKind.Explicit, Size=12)]
	public struct NETLOGON_DELTA_ENUM
	{
		[FieldOffset(0)]
		public NETLOGON_DELTA_TYPE DeltaType;

		[FieldOffset(4)]
		public NETLOGON_DELTA_ID_UNION DeltaID;

		[FieldOffset(8)]
		public NETLOGON_DELTA_UNION DeltaUnion;
	}

	[StructLayout(LayoutKind.Explicit, Size=12)]
	public struct NLPR_CR_CIPHER_VALUE
	{
		[FieldOffset(0)]
		public uint Length;

		[FieldOffset(4)]
		public uint MaximumLength;

		[FieldOffset(8)]
		public unsafe byte* Buffer;
	}

	[StructLayout(LayoutKind.Explicit, Size=96)]
	public struct BROWSER_STATISTICS
	{
		[FieldOffset(0)]
		public LARGE_INTEGER StatisticsStartTime;

		[FieldOffset(8)]
		public LARGE_INTEGER NumberOfServerAnnouncements;

		[FieldOffset(16)]
		public LARGE_INTEGER NumberOfDomainAnnouncements;

		[FieldOffset(24)]
		public uint NumberOfElectionPackets;

		[FieldOffset(28)]
		public uint NumberOfMailslotWrites;

		[FieldOffset(32)]
		public uint NumberOfGetBrowserServerListRequests;

		[FieldOffset(36)]
		public uint NumberOfServerEnumerations;

		[FieldOffset(40)]
		public uint NumberOfDomainEnumerations;

		[FieldOffset(44)]
		public uint NumberOfOtherEnumerations;

		[FieldOffset(48)]
		public uint NumberOfMissedServerAnnouncements;

		[FieldOffset(52)]
		public uint NumberOfMissedMailslotDatagrams;

		[FieldOffset(56)]
		public uint NumberOfMissedGetBrowserServerListRequests;

		[FieldOffset(60)]
		public uint NumberOfFailedServerAnnounceAllocations;

		[FieldOffset(64)]
		public uint NumberOfFailedMailslotAllocations;

		[FieldOffset(68)]
		public uint NumberOfFailedMailslotReceives;

		[FieldOffset(72)]
		public uint NumberOfFailedMailslotWrites;

		[FieldOffset(76)]
		public uint NumberOfFailedMailslotOpens;

		[FieldOffset(80)]
		public uint NumberOfDuplicateMasterAnnouncements;

		[FieldOffset(88)]
		public LARGE_INTEGER NumberOfIllegalDatagrams;
	}

	[StructLayout(LayoutKind.Explicit, Size=16)]
	public struct NL_GENERIC_RPC_DATA
	{
		[FieldOffset(0)]
		public uint UlongEntryCount;

		[FieldOffset(4)]
		public unsafe uint* UlongData;

		[FieldOffset(8)]
		public uint UnicodeStringEntryCount;

		[FieldOffset(12)]
		public unsafe UNICODE_STRING* UnicodeStringData;
	}

	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct NET_DFS_ENTRY_ID_CONTAINER
	{
		[FieldOffset(0)]
		public uint Count;

		[FieldOffset(4)]
		public unsafe NET_DFS_ENTRY_ID* Buffer;
	}

	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct NLPR_SID_ARRAY
	{
		[FieldOffset(0)]
		public uint Count;

		[FieldOffset(4)]
		public unsafe NLPR_SID_INFORMATION* Sids;
	}

	[StructLayout(LayoutKind.Explicit, Size=12)]
	public struct NLPR_USER_PRIVATE_INFO
	{
		[FieldOffset(0)]
		public byte SensitiveData;

		[FieldOffset(4)]
		public uint DataLength;

		[FieldOffset(8)]
		public unsafe byte* Data;
	}

	[StructLayout(LayoutKind.Explicit, Size=44)]
	public struct DS_DOMAIN_TRUSTSA
	{
		[FieldOffset(0)]
		public unsafe sbyte* NetbiosDomainName;

		[FieldOffset(4)]
		public unsafe sbyte* DnsDomainName;

		[FieldOffset(8)]
		public uint Flags;

		[FieldOffset(12)]
		public uint ParentIndex;

		[FieldOffset(16)]
		public uint TrustType;

		[FieldOffset(20)]
		public uint TrustAttributes;

		[FieldOffset(24)]
		public unsafe void* DomainSid;

		[FieldOffset(28)]
		public GUID DomainGuid;
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

	[StructLayout(LayoutKind.Explicit, Size=76)]
	public struct NETLOGON_DELTA_TRUSTED_DOMAINS
	{
		[FieldOffset(0)]
		public UNICODE_STRING DomainName;

		[FieldOffset(8)]
		public uint NumControllerEntries;

		[FieldOffset(12)]
		public unsafe UNICODE_STRING* ControllerNames;

		[FieldOffset(16)]
		public uint SecurityInformation;

		[FieldOffset(20)]
		public uint SecuritySize;

		[FieldOffset(24)]
		public unsafe byte* SecurityDescriptor;

		[FieldOffset(28)]
		public UNICODE_STRING DummyString1;

		[FieldOffset(36)]
		public UNICODE_STRING DummyString2;

		[FieldOffset(44)]
		public UNICODE_STRING DummyString3;

		[FieldOffset(52)]
		public UNICODE_STRING DummyString4;

		[FieldOffset(60)]
		public uint DummyLong1;

		[FieldOffset(64)]
		public uint DummyLong2;

		[FieldOffset(68)]
		public uint DummyLong3;

		[FieldOffset(72)]
		public uint DummyLong4;
	}

	[StructLayout(LayoutKind.Explicit, Size=24)]
	public struct NETLOGON_DELTA_ALIAS_MEMBER
	{
		[FieldOffset(0)]
		public NLPR_SID_ARRAY Members;

		[FieldOffset(8)]
		public uint DummyLong1;

		[FieldOffset(12)]
		public uint DummyLong2;

		[FieldOffset(16)]
		public uint DummyLong3;

		[FieldOffset(20)]
		public uint DummyLong4;
	}

	[StructLayout(LayoutKind.Explicit, Size=48)]
	public struct DOMAIN_CONTROLLER_INFOW
	{
		[FieldOffset(0)]
		public unsafe ushort* DomainControllerName;

		[FieldOffset(4)]
		public unsafe ushort* DomainControllerAddress;

		[FieldOffset(8)]
		public uint DomainControllerAddressType;

		[FieldOffset(12)]
		public GUID DomainGuid;

		[FieldOffset(28)]
		public unsafe ushort* DomainName;

		[FieldOffset(32)]
		public unsafe ushort* DnsForestName;

		[FieldOffset(36)]
		public uint Flags;

		[FieldOffset(40)]
		public unsafe ushort* DcSiteName;

		[FieldOffset(44)]
		public unsafe ushort* ClientSiteName;
	}

	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct SOCKET_ADDRESS
	{
		[FieldOffset(0)]
		public unsafe SOCKADDR* lpSockaddr;

		[FieldOffset(4)]
		public int iSockaddrLength;
	}

	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct LIST_ENTRY
	{
		[FieldOffset(0)]
		public unsafe LIST_ENTRY* Flink;

		[FieldOffset(4)]
		public unsafe LIST_ENTRY* Blink;
	}

	[StructLayout(LayoutKind.Explicit, Size=28)]
	public struct NETLOGON_DELTA_GROUP_MEMBER
	{
		[FieldOffset(0)]
		public unsafe uint* MemberIds;

		[FieldOffset(4)]
		public unsafe uint* Attributes;

		[FieldOffset(8)]
		public uint MemberCount;

		[FieldOffset(12)]
		public uint DummyLong1;

		[FieldOffset(16)]
		public uint DummyLong2;

		[FieldOffset(20)]
		public uint DummyLong3;

		[FieldOffset(24)]
		public uint DummyLong4;
	}

	[StructLayout(LayoutKind.Explicit, Size=24)]
	public struct DFSM_RELATION_INFO
	{
		[FieldOffset(0)]
		public uint cSubordinates;

		//Fixed-length Array "eid[1]". Members can be
		//accessed with (&my_DFSM_RELATION_INFO.eid_1)[index]
		[FieldOffset(4)]
		public DFSM_ENTRY_ID eid_1;
	}

	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct LSA_FOREST_TRUST_BINARY_DATA
	{
		[FieldOffset(0)]
		public uint Length;

		[FieldOffset(4)]
		public unsafe byte* Buffer;
	}

	[StructLayout(LayoutKind.Explicit, Size=64)]
	public struct NETLOGON_VALIDATION_UAS_INFO
	{
		[FieldOffset(0)]
		public unsafe ushort* usrlog1_eff_name;

		[FieldOffset(4)]
		public uint usrlog1_priv;

		[FieldOffset(8)]
		public uint usrlog1_auth_flags;

		[FieldOffset(12)]
		public uint usrlog1_num_logons;

		[FieldOffset(16)]
		public uint usrlog1_bad_pw_count;

		[FieldOffset(20)]
		public uint usrlog1_last_logon;

		[FieldOffset(24)]
		public uint usrlog1_last_logoff;

		[FieldOffset(28)]
		public uint usrlog1_logoff_time;

		[FieldOffset(32)]
		public uint usrlog1_kickoff_time;

		[FieldOffset(36)]
		public uint usrlog1_password_age;

		[FieldOffset(40)]
		public uint usrlog1_pw_can_change;

		[FieldOffset(44)]
		public uint usrlog1_pw_must_change;

		[FieldOffset(48)]
		public unsafe ushort* usrlog1_computer;

		[FieldOffset(52)]
		public unsafe ushort* usrlog1_domain;

		[FieldOffset(56)]
		public unsafe ushort* usrlog1_script_path;

		[FieldOffset(60)]
		public uint usrlog1_reserved1;
	}

	[StructLayout(LayoutKind.Explicit, Size=256)]
	public struct LANA_ENUM
	{
		[FieldOffset(0)]
		public byte length;

		//Fixed-length Array "lana[255]". Members can be
		//accessed with (&my_LANA_ENUM.lana_255)[index]
		[FieldOffset(1)]
		public byte lana_255;
	}

	[StructLayout(LayoutKind.Explicit, Size=16)]
	public struct SOCKADDR
	{
		[FieldOffset(0)]
		public ushort sa_family;

		//Fixed-length Array "sa_data[14]". Members can be
		//accessed with (&my_SOCKADDR.sa_data_14)[index]
		[FieldOffset(2)]
		public sbyte sa_data_14;
	}

	[StructLayout(LayoutKind.Explicit, Size=44)]
	public struct DS_DOMAIN_TRUSTSW
	{
		[FieldOffset(0)]
		public unsafe ushort* NetbiosDomainName;

		[FieldOffset(4)]
		public unsafe ushort* DnsDomainName;

		[FieldOffset(8)]
		public uint Flags;

		[FieldOffset(12)]
		public uint ParentIndex;

		[FieldOffset(16)]
		public uint TrustType;

		[FieldOffset(20)]
		public uint TrustAttributes;

		[FieldOffset(24)]
		public unsafe void* DomainSid;

		[FieldOffset(28)]
		public GUID DomainGuid;
	}

	[StructLayout(LayoutKind.Explicit, Size=140)]
	public struct NETLOGON_DELTA_POLICY
	{
		[FieldOffset(0)]
		public uint MaximumLogSize;

		[FieldOffset(4)]
		public OLD_LARGE_INTEGER AuditRetentionPeriod;

		[FieldOffset(12)]
		public byte AuditingMode;

		[FieldOffset(16)]
		public uint MaximumAuditEventCount;

		[FieldOffset(20)]
		public unsafe uint* EventAuditingOptions;

		[FieldOffset(24)]
		public UNICODE_STRING PrimaryDomainName;

		[FieldOffset(32)]
		public unsafe ISID* PrimaryDomainSid;

		[FieldOffset(36)]
		public NLPR_QUOTA_LIMITS QuotaLimits;

		[FieldOffset(64)]
		public OLD_LARGE_INTEGER ModifiedId;

		[FieldOffset(72)]
		public OLD_LARGE_INTEGER DatabaseCreationTime;

		[FieldOffset(80)]
		public uint SecurityInformation;

		[FieldOffset(84)]
		public uint SecuritySize;

		[FieldOffset(88)]
		public unsafe byte* SecurityDescriptor;

		[FieldOffset(92)]
		public UNICODE_STRING DummyString1;

		[FieldOffset(100)]
		public UNICODE_STRING DummyString2;

		[FieldOffset(108)]
		public UNICODE_STRING DummyString3;

		[FieldOffset(116)]
		public UNICODE_STRING DummyString4;

		[FieldOffset(124)]
		public uint DummyLong1;

		[FieldOffset(128)]
		public uint DummyLong2;

		[FieldOffset(132)]
		public uint DummyLong3;

		[FieldOffset(136)]
		public uint DummyLong4;
	}

	[StructLayout(LayoutKind.Explicit, Size=20)]
	public struct NET_DFS_ENTRY_ID
	{
		[FieldOffset(0)]
		public GUID Uid;

		[FieldOffset(16)]
		public unsafe ushort* Prefix;
	}

	[StructLayout(LayoutKind.Explicit, Size=6)]
	public struct SID_IDENTIFIER_AUTHORITY
	{
		//Fixed-length Array "Value[6]". Members can be
		//accessed with (&my_SID_IDENTIFIER_AUTHORITY.Value_6)[index]
		[FieldOffset(0)]
		public byte Value_6;
	}

	[StructLayout(LayoutKind.Explicit, Size=4)]
	public struct NETLOGON_DELTA_UNION
	{
		[FieldOffset(0)]
		public unsafe NETLOGON_DELTA_DOMAIN* DeltaDomain;

		[FieldOffset(0)]
		public unsafe NETLOGON_DELTA_GROUP* DeltaGroup;

		[FieldOffset(0)]
		public unsafe NETLOGON_DELTA_RENAME_USER* DeltaRenameGroup;

		[FieldOffset(0)]
		public unsafe NETLOGON_DELTA_USER* DeltaUser;

		[FieldOffset(0)]
		public unsafe NETLOGON_DELTA_RENAME_USER* DeltaRenameUser;

		[FieldOffset(0)]
		public unsafe NETLOGON_DELTA_GROUP_MEMBER* DeltaGroupMember;

		[FieldOffset(0)]
		public unsafe NETLOGON_DELTA_ALIAS* DeltaAlias;

		[FieldOffset(0)]
		public unsafe NETLOGON_DELTA_RENAME_USER* DeltaRenameAlias;

		[FieldOffset(0)]
		public unsafe NETLOGON_DELTA_ALIAS_MEMBER* DeltaAliasMember;

		[FieldOffset(0)]
		public unsafe NETLOGON_DELTA_POLICY* DeltaPolicy;

		[FieldOffset(0)]
		public unsafe NETLOGON_DELTA_TRUSTED_DOMAINS* DeltaTDomains;

		[FieldOffset(0)]
		public unsafe NETLOGON_DELTA_ACCOUNTS* DeltaAccounts;

		[FieldOffset(0)]
		public unsafe NETLOGON_DELTA_SECRET* DeltaSecret;

		[FieldOffset(0)]
		public unsafe NETLOGON_DELTA_DELETE_USER* DeltaDeleteGroup;

		[FieldOffset(0)]
		public unsafe NETLOGON_DELTA_DELETE_USER* DeltaDeleteUser;

		[FieldOffset(0)]
		public unsafe NLPR_MODIFIED_COUNT* DeltaSerialNumberSkip;
	}

	[StructLayout(LayoutKind.Explicit, Size=20)]
	public struct DFSM_ENTRY_ID
	{
		[FieldOffset(0)]
		public GUID idSubordinate;

		[FieldOffset(16)]
		public unsafe ushort* wszSubordinate;
	}

	[StructLayout(LayoutKind.Explicit, Size=16)]
	public struct ENCRYPTED_LM_OWF_PASSWORD
	{
		//Fixed-length Array "data[2]". Members can be
		//accessed with (&my_ENCRYPTED_LM_OWF_PASSWORD.data_2)[index]
		[FieldOffset(0)]
		public CYPHER_BLOCK data_2;
	}

	[StructLayout(LayoutKind.Explicit, Size=12)]
	public struct BROWSER_EMULATED_DOMAIN
	{
		[FieldOffset(0)]
		public unsafe ushort* DomainName;

		[FieldOffset(4)]
		public unsafe ushort* EmulatedServerName;

		[FieldOffset(8)]
		public uint Role;
	}

	[StructLayout(LayoutKind.Explicit, Size=100)]
	public struct NETLOGON_DELTA_SECRET
	{
		[FieldOffset(0)]
		public NLPR_CR_CIPHER_VALUE CurrentValue;

		[FieldOffset(12)]
		public OLD_LARGE_INTEGER CurrentValueSetTime;

		[FieldOffset(20)]
		public NLPR_CR_CIPHER_VALUE OldValue;

		[FieldOffset(32)]
		public OLD_LARGE_INTEGER OldValueSetTime;

		[FieldOffset(40)]
		public uint SecurityInformation;

		[FieldOffset(44)]
		public uint SecuritySize;

		[FieldOffset(48)]
		public unsafe byte* SecurityDescriptor;

		[FieldOffset(52)]
		public UNICODE_STRING DummyString1;

		[FieldOffset(60)]
		public UNICODE_STRING DummyString2;

		[FieldOffset(68)]
		public UNICODE_STRING DummyString3;

		[FieldOffset(76)]
		public UNICODE_STRING DummyString4;

		[FieldOffset(84)]
		public uint DummyLong1;

		[FieldOffset(88)]
		public uint DummyLong2;

		[FieldOffset(92)]
		public uint DummyLong3;

		[FieldOffset(96)]
		public uint DummyLong4;
	}

	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct NLPR_MODIFIED_COUNT
	{
		[FieldOffset(0)]
		public OLD_LARGE_INTEGER ModifiedCount;
	}

	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct CYPHER_BLOCK
	{
		//Fixed-length Array "data[8]". Members can be
		//accessed with (&my_CYPHER_BLOCK.data_8)[index]
		[FieldOffset(0)]
		public sbyte data_8;
	}

	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct NETLOGON_DELTA_ENUM_ARRAY
	{
		[FieldOffset(0)]
		public uint CountReturned;

		[FieldOffset(4)]
		public unsafe NETLOGON_DELTA_ENUM* Deltas;
	}

	[StructLayout(LayoutKind.Explicit, Size=16)]
	public struct DSROLE_SERVEROP_RESULTS
	{
		[FieldOffset(0)]
		public uint OperationStatus;

		[FieldOffset(4)]
		public unsafe ushort* OperationStatusDisplayString;

		[FieldOffset(8)]
		public unsafe ushort* ServerInstalledSite;

		[FieldOffset(12)]
		public uint OperationResultsFlags;
	}

	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct OLD_LARGE_INTEGER
	{
		[FieldOffset(0)]
		public uint LowPart;

		[FieldOffset(4)]
		public int HighPart;
	}

	[StructLayout(LayoutKind.Explicit, Size=64)]
	public struct NETLOGON_DELTA_RENAME_USER
	{
		[FieldOffset(0)]
		public UNICODE_STRING OldName;

		[FieldOffset(8)]
		public UNICODE_STRING NewName;

		[FieldOffset(16)]
		public UNICODE_STRING DummyString1;

		[FieldOffset(24)]
		public UNICODE_STRING DummyString2;

		[FieldOffset(32)]
		public UNICODE_STRING DummyString3;

		[FieldOffset(40)]
		public UNICODE_STRING DummyString4;

		[FieldOffset(48)]
		public uint DummyLong1;

		[FieldOffset(52)]
		public uint DummyLong2;

		[FieldOffset(56)]
		public uint DummyLong3;

		[FieldOffset(60)]
		public uint DummyLong4;
	}

	[StructLayout(LayoutKind.Explicit, Size=516)]
	public struct NL_TRUST_PASSWORD
	{
		//Fixed-length Array "Buffer[256]". Members can be
		//accessed with (&my_NL_TRUST_PASSWORD.Buffer_256)[index]
		[FieldOffset(0)]
		public ushort Buffer_256;

		[FieldOffset(512)]
		public uint Length;
	}

	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct NLPR_LOGON_HOURS
	{
		[FieldOffset(0)]
		public ushort UnitsPerWeek;

		[FieldOffset(4)]
		public unsafe byte* LogonHours;
	}

	[StructLayout(LayoutKind.Explicit, Size=12)]
	public struct ACE_DATA
	{
		[FieldOffset(0)]
		public byte AceType;

		[FieldOffset(1)]
		public byte InheritFlags;

		[FieldOffset(2)]
		public byte AceFlags;

		[FieldOffset(4)]
		public uint Mask;

		[FieldOffset(8)]
		public unsafe void** Sid;
	}

	[StructLayout(LayoutKind.Explicit, Size=240)]
	public struct NETLOGON_DELTA_USER
	{
		[FieldOffset(0)]
		public UNICODE_STRING UserName;

		[FieldOffset(8)]
		public UNICODE_STRING FullName;

		[FieldOffset(16)]
		public uint UserId;

		[FieldOffset(20)]
		public uint PrimaryGroupId;

		[FieldOffset(24)]
		public UNICODE_STRING HomeDirectory;

		[FieldOffset(32)]
		public UNICODE_STRING HomeDirectoryDrive;

		[FieldOffset(40)]
		public UNICODE_STRING ScriptPath;

		[FieldOffset(48)]
		public UNICODE_STRING AdminComment;

		[FieldOffset(56)]
		public UNICODE_STRING WorkStations;

		[FieldOffset(64)]
		public OLD_LARGE_INTEGER LastLogon;

		[FieldOffset(72)]
		public OLD_LARGE_INTEGER LastLogoff;

		[FieldOffset(80)]
		public NLPR_LOGON_HOURS LogonHours;

		[FieldOffset(88)]
		public ushort BadPasswordCount;

		[FieldOffset(90)]
		public ushort LogonCount;

		[FieldOffset(92)]
		public OLD_LARGE_INTEGER PasswordLastSet;

		[FieldOffset(100)]
		public OLD_LARGE_INTEGER AccountExpires;

		[FieldOffset(108)]
		public uint UserAccountControl;

		[FieldOffset(112)]
		public ENCRYPTED_LM_OWF_PASSWORD EncryptedNtOwfPassword;

		[FieldOffset(128)]
		public ENCRYPTED_LM_OWF_PASSWORD EncryptedLmOwfPassword;

		[FieldOffset(144)]
		public byte NtPasswordPresent;

		[FieldOffset(145)]
		public byte LmPasswordPresent;

		[FieldOffset(146)]
		public byte PasswordExpired;

		[FieldOffset(148)]
		public UNICODE_STRING UserComment;

		[FieldOffset(156)]
		public UNICODE_STRING Parameters;

		[FieldOffset(164)]
		public ushort CountryCode;

		[FieldOffset(166)]
		public ushort CodePage;

		[FieldOffset(168)]
		public NLPR_USER_PRIVATE_INFO PrivateData;

		[FieldOffset(180)]
		public uint SecurityInformation;

		[FieldOffset(184)]
		public uint SecuritySize;

		[FieldOffset(188)]
		public unsafe byte* SecurityDescriptor;

		[FieldOffset(192)]
		public UNICODE_STRING DummyString1;

		[FieldOffset(200)]
		public UNICODE_STRING DummyString2;

		[FieldOffset(208)]
		public UNICODE_STRING DummyString3;

		[FieldOffset(216)]
		public UNICODE_STRING DummyString4;

		[FieldOffset(224)]
		public uint DummyLong1;

		[FieldOffset(228)]
		public uint DummyLong2;

		[FieldOffset(232)]
		public uint DummyLong3;

		[FieldOffset(236)]
		public uint DummyLong4;
	}

	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct LSA_FOREST_TRUST_INFORMATION
	{
		[FieldOffset(0)]
		public uint RecordCount;

		[FieldOffset(4)]
		public unsafe LSA_FOREST_TRUST_RECORD** Entries;
	}

	[StructLayout(LayoutKind.Explicit, Size=20)]
	public struct LSA_FOREST_TRUST_DOMAIN_INFO
	{
		[FieldOffset(0)]
		public unsafe void* Sid;

		[FieldOffset(4)]
		public UNICODE_STRING DnsName;

		[FieldOffset(12)]
		public UNICODE_STRING NetbiosName;
	}

	[StructLayout(LayoutKind.Explicit, Size=40)]
	public struct LSA_FOREST_TRUST_RECORD
	{
		[FieldOffset(0)]
		public uint Flags;

		[FieldOffset(4)]
		public LSA_FOREST_TRUST_RECORD_TYPE ForestTrustType;

		[FieldOffset(8)]
		public LARGE_INTEGER Time;

		[FieldOffset(16)]
		public nested_ForestTrustData ForestTrustData;
		[StructLayout(LayoutKind.Explicit, Size=20)]
		public struct nested_ForestTrustData
		{
			[FieldOffset(0)]
			public UNICODE_STRING TopLevelName;

			[FieldOffset(0)]
			public LSA_FOREST_TRUST_DOMAIN_INFO DomainInfo;

			[FieldOffset(0)]
			public LSA_FOREST_TRUST_BINARY_DATA Data;
		}
	}

	[StructLayout(LayoutKind.Explicit, Size=108)]
	public struct NETLOGON_DELTA_ACCOUNTS
	{
		[FieldOffset(0)]
		public uint PrivilegeEntries;

		[FieldOffset(4)]
		public uint PrivilegeControl;

		[FieldOffset(8)]
		public unsafe uint* PrivilegeAttributes;

		[FieldOffset(12)]
		public unsafe UNICODE_STRING* PrivilegeNames;

		[FieldOffset(16)]
		public NLPR_QUOTA_LIMITS QuotaLimits;

		[FieldOffset(44)]
		public uint SystemAccessFlags;

		[FieldOffset(48)]
		public uint SecurityInformation;

		[FieldOffset(52)]
		public uint SecuritySize;

		[FieldOffset(56)]
		public unsafe byte* SecurityDescriptor;

		[FieldOffset(60)]
		public UNICODE_STRING DummyString1;

		[FieldOffset(68)]
		public UNICODE_STRING DummyString2;

		[FieldOffset(76)]
		public UNICODE_STRING DummyString3;

		[FieldOffset(84)]
		public UNICODE_STRING DummyString4;

		[FieldOffset(92)]
		public uint DummyLong1;

		[FieldOffset(96)]
		public uint DummyLong2;

		[FieldOffset(100)]
		public uint DummyLong3;

		[FieldOffset(104)]
		public uint DummyLong4;
	}

	[StructLayout(LayoutKind.Explicit, Size=12)]
	public struct DFS_SITELIST_INFO
	{
		[FieldOffset(0)]
		public uint cSites;

		//Fixed-length Array "Site[1]". Members can be
		//accessed with (&my_DFS_SITELIST_INFO.Site_1)[index]
		[FieldOffset(4)]
		public DFS_SITENAME_INFO Site_1;
	}

	[StructLayout(LayoutKind.Explicit, Size=84)]
	public struct NETLOGON_DELTA_GROUP
	{
		[FieldOffset(0)]
		public UNICODE_STRING Name;

		[FieldOffset(8)]
		public uint RelativeId;

		[FieldOffset(12)]
		public uint Attributes;

		[FieldOffset(16)]
		public UNICODE_STRING AdminComment;

		[FieldOffset(24)]
		public uint SecurityInformation;

		[FieldOffset(28)]
		public uint SecuritySize;

		[FieldOffset(32)]
		public unsafe byte* SecurityDescriptor;

		[FieldOffset(36)]
		public UNICODE_STRING DummyString1;

		[FieldOffset(44)]
		public UNICODE_STRING DummyString2;

		[FieldOffset(52)]
		public UNICODE_STRING DummyString3;

		[FieldOffset(60)]
		public UNICODE_STRING DummyString4;

		[FieldOffset(68)]
		public uint DummyLong1;

		[FieldOffset(72)]
		public uint DummyLong2;

		[FieldOffset(76)]
		public uint DummyLong3;

		[FieldOffset(80)]
		public uint DummyLong4;
	}

	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct STRING
	{
		[FieldOffset(0)]
		public ushort Length;

		[FieldOffset(2)]
		public ushort MaximumLength;

		[FieldOffset(4)]
		public unsafe sbyte* Buffer;
	}

	[StructLayout(LayoutKind.Explicit, Size=52)]
	public struct NETLOGON_DELTA_DELETE_USER
	{
		[FieldOffset(0)]
		public unsafe ushort* AccountName;

		[FieldOffset(4)]
		public UNICODE_STRING DummyString1;

		[FieldOffset(12)]
		public UNICODE_STRING DummyString2;

		[FieldOffset(20)]
		public UNICODE_STRING DummyString3;

		[FieldOffset(28)]
		public UNICODE_STRING DummyString4;

		[FieldOffset(36)]
		public uint DummyLong1;

		[FieldOffset(40)]
		public uint DummyLong2;

		[FieldOffset(44)]
		public uint DummyLong3;

		[FieldOffset(48)]
		public uint DummyLong4;
	}

	[StructLayout(LayoutKind.Explicit, Size=12)]
	public struct NETLOGON_AUTHENTICATOR
	{
		[FieldOffset(0)]
		public CYPHER_BLOCK Credential;

		[FieldOffset(8)]
		public uint timestamp;
	}

	[StructLayout(LayoutKind.Explicit, Size=16)]
	public struct HLOG
	{
		[FieldOffset(0)]
		public uint time;

		[FieldOffset(4)]
		public uint last_flags;

		[FieldOffset(8)]
		public uint offset;

		[FieldOffset(12)]
		public uint rec_offset;
	}

	[StructLayout(LayoutKind.Explicit, Size=4)]
	public struct NLPR_SID_INFORMATION
	{
		[FieldOffset(0)]
		public unsafe ISID* SidPointer;
	}

	[StructLayout(LayoutKind.Explicit, Size=64)]
	public struct NCB
	{
		[FieldOffset(0)]
		public byte ncb_command;

		[FieldOffset(1)]
		public byte ncb_retcode;

		[FieldOffset(2)]
		public byte ncb_lsn;

		[FieldOffset(3)]
		public byte ncb_num;

		[FieldOffset(4)]
		public unsafe byte* ncb_buffer;

		[FieldOffset(8)]
		public ushort ncb_length;

		//Fixed-length Array "ncb_callname[16]". Members can be
		//accessed with (&my_NCB.ncb_callname_16)[index]
		[FieldOffset(10)]
		public byte ncb_callname_16;

		//Fixed-length Array "ncb_name[16]". Members can be
		//accessed with (&my_NCB.ncb_name_16)[index]
		[FieldOffset(26)]
		public byte ncb_name_16;

		[FieldOffset(42)]
		public byte ncb_rto;

		[FieldOffset(43)]
		public byte ncb_sto;

		[FieldOffset(44)]
		public unsafe /*fn ptr->delegate: GeneratedDelegate1*/ void* ncb_post;

		[FieldOffset(48)]
		public byte ncb_lana_num;

		[FieldOffset(49)]
		public byte ncb_cmd_cplt;

		//Fixed-length Array "ncb_reserve[10]". Members can be
		//accessed with (&my_NCB.ncb_reserve_10)[index]
		[FieldOffset(50)]
		public byte ncb_reserve_10;

		[FieldOffset(60)]
		public unsafe void* ncb_event;
	}

	[StructLayout(LayoutKind.Explicit, Size=16)]
	public struct GENERIC_MAPPING
	{
		[FieldOffset(0)]
		public uint GenericRead;

		[FieldOffset(4)]
		public uint GenericWrite;

		[FieldOffset(8)]
		public uint GenericExecute;

		[FieldOffset(12)]
		public uint GenericAll;
	}

	[StructLayout(LayoutKind.Explicit, Size=12)]
	public struct DSROLE_SERVEROP_STATUS
	{
		[FieldOffset(0)]
		public unsafe ushort* CurrentOperationDisplayString;

		[FieldOffset(4)]
		public uint OperationStatus;

		[FieldOffset(8)]
		public uint CurrentOperationDisplayStringIndex;
	}
	#endregion

	#region enums (14)

	public enum TARGET_NAME_TYPE : int
	{
		IsUsernameTarget = 0,
		IsNotUsernameTarget = 1,
		MightBeUsernameTarget = 2
	}

	public enum DSROLE_PRIMARY_DOMAIN_INFO_LEVEL : int
	{
		DsRolePrimaryDomainInfoBasic = 1,
		DsRoleUpgradeStatus = 2,
		DsRoleOperationState = 3
	}

	public enum NETSETUP_NAME_TYPE : int
	{
		NetSetupUnknown = 0,
		NetSetupMachine = 1,
		NetSetupWorkgroup = 2,
		NetSetupDomain = 3,
		NetSetupNonExistentDomain = 4,
		NetSetupDnsMachine = 5
	}

	public enum NETLOGON_DELTA_TYPE : int
	{
		AddOrChangeDomain = 1,
		AddOrChangeGroup = 2,
		DeleteGroup = 3,
		RenameGroup = 4,
		AddOrChangeUser = 5,
		DeleteUser = 6,
		RenameUser = 7,
		ChangeGroupMembership = 8,
		AddOrChangeAlias = 9,
		DeleteAlias = 10,
		RenameAlias = 11,
		ChangeAliasMembership = 12,
		AddOrChangeLsaPolicy = 13,
		AddOrChangeLsaTDomain = 14,
		DeleteLsaTDomain = 15,
		AddOrChangeLsaAccount = 16,
		DeleteLsaAccount = 17,
		AddOrChangeLsaSecret = 18,
		DeleteLsaSecret = 19,
		DeleteGroupByName = 20,
		DeleteUserByName = 21,
		SerialNumberSkip = 22,
		DummyChangeLogEntry = 23
	}

	public enum LSA_FOREST_TRUST_RECORD_TYPE : int
	{
		ForestTrustTopLevelName = 0,
		ForestTrustTopLevelNameEx = 1,
		ForestTrustDomainInfo = 2,
		ForestTrustRecordTypeLast = 2
	}

	public enum NETLOGON_VALIDATION_INFO_CLASS : int
	{
		NetlogonValidationUasInfo = 1,
		NetlogonValidationSamInfo = 2,
		NetlogonValidationSamInfo2 = 3,
		NetlogonValidationGenericInfo = 4,
		NetlogonValidationGenericInfo2 = 5,
		NetlogonValidationSamInfo4 = 6
	}

	public enum SYNC_STATE : int
	{
		NormalState = 0,
		DomainState = 1,
		GroupState = 2,
		UasBuiltinGroupState = 3,
		UserState = 4,
		GroupMemberState = 5,
		AliasState = 6,
		AliasMemberState = 7,
		SamDoneState = 8
	}

	public enum WILDCARD_TYPE : int
	{
		WcDfsShareName = 0,
		WcServerName = 1,
		WcServerWildcard = 2,
		WcDomainWildcard = 3,
		WcUniversalSessionWildcard = 4,
		WcUniversalWildcard = 5,
		WcUserName = 6
	}

	public enum NET_COMPUTER_NAME_TYPE : int
	{
		NetPrimaryComputerName = 0,
		NetAlternateComputerNames = 1,
		NetAllComputerNames = 2,
		NetComputerNameTypeMax = 3
	}

	public enum NETSETUP_JOIN_STATUS : int
	{
		NetSetupUnknownStatus = 0,
		NetSetupUnjoined = 1,
		NetSetupWorkgroupName = 2,
		NetSetupDomainName = 3
	}

	public enum NETLOGON_LOGON_INFO_CLASS : int
	{
		NetlogonInteractiveInformation = 1,
		NetlogonNetworkInformation = 2,
		NetlogonServiceInformation = 3,
		NetlogonGenericInformation = 4,
		NetlogonInteractiveTransitiveInformation = 5,
		NetlogonNetworkTransitiveInformation = 6,
		NetlogonServiceTransitiveInformation = 7
	}

	public enum NETLOGON_SECURE_CHANNEL_TYPE : int
	{
		NullSecureChannel = 0,
		MsvApSecureChannel = 1,
		WorkstationSecureChannel = 2,
		TrustedDnsDomainSecureChannel = 3,
		TrustedDomainSecureChannel = 4,
		UasServerSecureChannel = 5,
		ServerSecureChannel = 6
	}

	public enum DSROLE_SERVEROP_DEMOTE_ROLE : int
	{
		DsRoleServerStandalone = 0,
		DsRoleServerMember = 1
	}

	public enum NL_RPC_BINDING : int
	{
		UseAny = 0,
		UseNamedPipe = 1,
		UseTcpIp = 2
	}
	#endregion

	#region delegates (1)
	//note: Delegates marshalled from Function Ptrs pointing to 
	//	unmanaged code cannot be called from C# in version 7.0
	public unsafe delegate void GeneratedDelegate1(NCB* arg1);

	#region delegate helper functions
	class Helpers
	{
		//These helper functions are generated as a workaround to allow
		//	the conversion of a Delegate to void *.  This allows the user
		//	to avoid dealing with the Marshalling of delegates when
		//	allowing unmanaged code to call a C# function.
	
		public static unsafe void* DelegateToPtr(GeneratedDelegate1 d){ return lstrcpyn(d, null, 0); }
		[DllImport("kernel32")] private static unsafe extern void* lstrcpyn(
			[MarshalAs(UnmanagedType.FunctionPtr)] GeneratedDelegate1 d, void* pSrc, int maxLength);
	}
	#endregion
	#endregion
}

//comletion time: 5:17:41 PM
