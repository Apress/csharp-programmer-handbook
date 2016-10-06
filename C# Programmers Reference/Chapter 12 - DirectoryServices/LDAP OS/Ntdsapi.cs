using System;
using System.Runtime.InteropServices;

//generated on 6/26/2003 at 5:16:23 PM
namespace LDAP.Ntdsapi
{
	class Ntdsapi
	{
		//96 functions were generated: C:\DBG\PDB2CS\src\release\ntdsapi.dll

		[DllImport(@"ntdsapi", EntryPoint="DsReplicaModifyA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsReplicaModifyA(void* hDS, sbyte* NameContext, GUID* pUuidSourceDsa, sbyte* TransportDn, sbyte* SourceDsaAddress, SCHEDULE* pSchedule, uint ReplicaFlags, uint ModifyFields, uint Options);

		[DllImport(@"ntdsapi", EntryPoint="DsFreeNameResultW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe void DsFreeNameResultW(DS_NAME_RESULTW* pResult);

		[DllImport(@"ntdsapi", EntryPoint="DsAddSidHistoryW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsAddSidHistoryW(void* hDs, uint Flags, ushort* SrcDomain, ushort* SrcPrincipal, ushort* SrcDomainController, void* SrcDomainCreds, ushort* DstDomain, ushort* DstPrincipal);

		[DllImport(@"ntdsapi", EntryPoint="DsaopExecuteScript", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsaopExecuteScript(void* phAsync, void* hRpc, uint cbPassword, byte* pbPassword, uint* dwOutVersion, void* reply);

		[DllImport(@"ntdsapi", EntryPoint="DsListServersForDomainInSiteW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsListServersForDomainInSiteW(void* hDs, ushort* domain, ushort* site, DS_NAME_RESULTW** ppServers);

		[DllImport(@"ntdsapi", EntryPoint="DsFreeSpnArrayA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe void DsFreeSpnArrayA(uint cSpn, ushort** rpszSpn);

		[DllImport(@"ntdsapi", EntryPoint="DsAddSidHistoryA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsAddSidHistoryA(void* hDs, uint Flags, sbyte* SrcDomain, sbyte* SrcPrincipal, sbyte* SrcDomainController, void* SrcDomainCreds, sbyte* DstDomain, sbyte* DstPrincipal);

		[DllImport(@"ntdsapi", EntryPoint="DsListRolesA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsListRolesA(void* hDs, DS_NAME_RESULTA** ppRoles);

		[DllImport(@"ntdsapi", EntryPoint="DsQuoteRdnValueA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsQuoteRdnValueA(uint cUnquotedRdnValueLength, sbyte* psUnquotedRdnValue, uint* pcQuotedRdnValueLength, sbyte* psQuotedRdnValue);

		[DllImport(@"ntdsapi", EntryPoint="DsReplicaFreeInfo", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe void DsReplicaFreeInfo(DS_REPL_INFO_TYPE InfoType, void* pInfo);

		[DllImport(@"ntdsapi", EntryPoint="DsFreeNameResultA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe void DsFreeNameResultA(DS_NAME_RESULTW* pResult);

		[DllImport(@"ntdsapi", EntryPoint="DsUnBindW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsUnBindW(void** phDS);

		[DllImport(@"ntdsapi", EntryPoint="DsFreeSpnArrayW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe void DsFreeSpnArrayW(uint cSpn, ushort** rpszSpn);

		[DllImport(@"ntdsapi", EntryPoint="DsReplicaDelA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsReplicaDelA(void* hDS, sbyte* NameContext, sbyte* DsaSrc, uint Options);

		[DllImport(@"ntdsapi", EntryPoint="DsUnBindA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsUnBindA(void** phDS);

		[DllImport(@"ntdsapi", EntryPoint="DsQuoteRdnValueW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsQuoteRdnValueW(uint cUnquotedRdnValueLength, ushort* psUnquotedRdnValue, uint* pcQuotedRdnValueLength, ushort* psQuotedRdnValue);

		[DllImport(@"ntdsapi", EntryPoint="DsReplicaSyncAllA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsReplicaSyncAllA(void* hDS, sbyte* pszNameContext, uint ulFlags, /*fn ptr->delegate: GeneratedDelegate1*/ void* pFnCallBack, void* pCallbackData, DS_REPSYNCALL_ERRINFOA*** papErrInfo);

		[DllImport(@"ntdsapi", EntryPoint="DsListRolesW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsListRolesW(void* hDs, DS_NAME_RESULTW** ppRoles);

		[DllImport(@"ntdsapi", EntryPoint="DsGetSpnA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsGetSpnA(DS_SPN_NAME_TYPE ServiceType, sbyte* ServiceClass, sbyte* ServiceName, ushort InstancePort, ushort cInstanceNames, sbyte** pInstanceNames, ushort* pInstancePorts, uint* pcSpn, sbyte*** prpszSpn);

		[DllImport(@"ntdsapi", EntryPoint="DsClientMakeSpnForTargetServerA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsClientMakeSpnForTargetServerA(sbyte* ServiceClass, sbyte* ServiceName, uint* pcSpnLength, sbyte* pszSpn);

		[DllImport(@"ntdsapi", EntryPoint="DsListInfoForServerW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsListInfoForServerW(void* hDs, ushort* server, DS_NAME_RESULTW** ppInfo);

		[DllImport(@"ntdsapi", EntryPoint="DsRemoveDsDomainW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsRemoveDsDomainW(void* hDs, ushort* DomainDN);

		[DllImport(@"ntdsapi", EntryPoint="DsCrackNamesA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsCrackNamesA(void* hDS, DS_NAME_FLAGS flags, DS_NAME_FORMAT formatOffered, DS_NAME_FORMAT formatDesired, uint cNames, sbyte** rpNames, DS_NAME_RESULTA** ppResult);

		[DllImport(@"ntdsapi", EntryPoint="DsReplicaDelW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsReplicaDelW(void* hDS, ushort* NameContext, ushort* DsaSrc, uint Options);

		[DllImport(@"ntdsapi", EntryPoint="DsGetRdnW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsGetRdnW(ushort** ppDN, uint* pcDN, ushort** ppKey, uint* pcKey, ushort** ppVal, uint* pcVal);

		[DllImport(@"ntdsapi", EntryPoint="DsReplicaGetInfoW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsReplicaGetInfoW(void* hDS, DS_REPL_INFO_TYPE InfoType, ushort* pszObjectDN, GUID* puuidForSourceDsaObjGuid, void** ppInfo);

		[DllImport(@"ntdsapi", EntryPoint="DsCrackSpn2W", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsCrackSpn2W(ushort* pszSpn, uint cSpn, uint* pcServiceClass, ushort* ServiceClass, uint* pcServiceName, ushort* ServiceName, uint* pcInstanceName, ushort* InstanceName, ushort* pInstancePort);

		[DllImport(@"ntdsapi", EntryPoint="DsaopBindWithCred", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsaopBindWithCred(ushort* DomainControllerName, ushort* DnsDomainName, void* AuthIdentity, uint AuthnSvc, uint AuthnLevel, void** phRpc);

		[DllImport(@"ntdsapi", EntryPoint="DsReplicaSyncAllW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsReplicaSyncAllW(void* hDS, ushort* pszNameContext, uint ulFlags, /*fn ptr->delegate: GeneratedDelegate2*/ void* pFnCallBack, void* pCallbackData, DS_REPSYNCALL_ERRINFOW*** papErrInfo);

		[DllImport(@"ntdsapi", EntryPoint="DsRemoveDsDomainA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsRemoveDsDomainA(void* hDs, sbyte* DomainDN);

		[DllImport(@"ntdsapi", EntryPoint="DsReplicaUpdateRefsW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsReplicaUpdateRefsW(void* hDS, ushort* NameContext, ushort* DsaDest, GUID* pUuidDsaDest, uint Options);

		[DllImport(@"ntdsapi", EntryPoint="DsListInfoForServerA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsListInfoForServerA(void* hDs, sbyte* server, DS_NAME_RESULTA** ppInfo);

		[DllImport(@"ntdsapi", EntryPoint="DsReplicaGetInfo2W", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsReplicaGetInfo2W(void* hDS, DS_REPL_INFO_TYPE InfoType, ushort* pszObjectDN, GUID* puuidForSourceDsaObjGuid, ushort* pszAttributeName, ushort* pszValueDN, uint dwFlags, uint dwEnumerationContext, void** ppInfo);

		[DllImport(@"ntdsapi", EntryPoint="DsCrackNamesW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsCrackNamesW(void* hDS, DS_NAME_FLAGS flags, DS_NAME_FORMAT formatOffered, DS_NAME_FORMAT formatDesired, uint cNames, ushort** rpNames, DS_NAME_RESULTW** ppResult);

		[DllImport(@"ntdsapi", EntryPoint="DsFreeSchemaGuidMapW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe void DsFreeSchemaGuidMapW(DS_SCHEMA_GUID_MAPW* pMap);

		[DllImport(@"ntdsapi", EntryPoint="DsServerRegisterSpnA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsServerRegisterSpnA(DS_SPN_WRITE_OP Operation, sbyte* ServiceClass, sbyte* UserObjectDN);

		[DllImport(@"ntdsapi", EntryPoint="DsUnquoteRdnValueA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsUnquoteRdnValueA(uint cQuotedRdnValueLength, sbyte* psQuotedRdnValue, uint* pcUnquotedRdnValueLength, sbyte* psUnquotedRdnValue);

		[DllImport(@"ntdsapi", EntryPoint="DsaopUnBind", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsaopUnBind(void** phRpc);

		[DllImport(@"ntdsapi", EntryPoint="DsGetDomainControllerInfoA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsGetDomainControllerInfoA(void* hDs, sbyte* DomainName, uint InfoLevel, uint* pcOut, void** ppInfo);

		[DllImport(@"ntdsapi", EntryPoint="DsGetSpnW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsGetSpnW(DS_SPN_NAME_TYPE ServiceType, ushort* ServiceClass, ushort* ServiceName, ushort InstancePort, ushort cInstanceNames, ushort** pInstanceNames, ushort* pInstancePorts, uint* pcSpn, ushort*** prpszSpn);

		[DllImport(@"ntdsapi", EntryPoint="DsaopBind", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsaopBind(ushort* DomainControllerName, ushort* DnsDomainName, uint AuthnSvc, uint AuthnLevel, void** phRpc);

		[DllImport(@"ntdsapi", EntryPoint="DsListDomainsInSiteW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsListDomainsInSiteW(void* hDs, ushort* site, DS_NAME_RESULTW** ppDomains);

		[DllImport(@"ntdsapi", EntryPoint="DsReplicaAddA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsReplicaAddA(void* hDS, sbyte* NameContext, sbyte* SourceDsaDn, sbyte* TransportDn, sbyte* SourceDsaAddress, SCHEDULE* pSchedule, uint Options);

		[DllImport(@"ntdsapi", EntryPoint="DsReplicaUpdateRefsA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsReplicaUpdateRefsA(void* hDS, sbyte* NameContext, sbyte* DsaDest, GUID* pUuidDsaDest, uint Options);

		[DllImport(@"ntdsapi", EntryPoint="DsServerRegisterSpnW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsServerRegisterSpnW(DS_SPN_WRITE_OP Operation, ushort* ServiceClass, ushort* UserObjectDN);

		[DllImport(@"ntdsapi", EntryPoint="DsaopPrepareScript", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsaopPrepareScript(void* phAsync, void* hRpc, uint* dwOutVersion, void* reply);

		[DllImport(@"ntdsapi", EntryPoint="DsFreeSchemaGuidMapA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe void DsFreeSchemaGuidMapA(DS_SCHEMA_GUID_MAPA* pMap);

		[DllImport(@"ntdsapi", EntryPoint="DsListDomainsInSiteA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsListDomainsInSiteA(void* hDs, sbyte* site, DS_NAME_RESULTA** ppDomains);

		[DllImport(@"ntdsapi", EntryPoint="DsIsMangledDnA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int DsIsMangledDnA(sbyte* pszDn, DS_MANGLE_FOR eDsMangleFor);

		[DllImport(@"ntdsapi", EntryPoint="DsInheritSecurityIdentityA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsInheritSecurityIdentityA(void* hDs, uint Flags, sbyte* SrcPrincipal, sbyte* DstPrincipal);

		[DllImport(@"ntdsapi", EntryPoint="DsGetDomainControllerInfoW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsGetDomainControllerInfoW(void* hDs, ushort* DomainName, uint InfoLevel, uint* pcOut, void** ppInfo);

		[DllImport(@"ntdsapi", EntryPoint="DsReplicaSyncA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsReplicaSyncA(void* hDS, sbyte* NameContext, GUID* pUuidDsaSrc, uint Options);

		[DllImport(@"ntdsapi", EntryPoint="DsWriteAccountSpnA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsWriteAccountSpnA(void* hDS, DS_SPN_WRITE_OP Operation, sbyte* pszAccount, uint cSpn, sbyte** rpszSpn);

		[DllImport(@"ntdsapi", EntryPoint="DsMakeSpnA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsMakeSpnA(sbyte* ServiceClass, sbyte* ServiceName, sbyte* InstanceName, ushort InstancePort, sbyte* Referrer, uint* pcSpnLength, sbyte* pszSpn);

		[DllImport(@"ntdsapi", EntryPoint="DsUnquoteRdnValueW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsUnquoteRdnValueW(uint cQuotedRdnValueLength, ushort* psQuotedRdnValue, uint* pcUnquotedRdnValueLength, ushort* psUnquotedRdnValue);

		[DllImport(@"ntdsapi", EntryPoint="DsClientMakeSpnForTargetServerW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsClientMakeSpnForTargetServerW(ushort* ServiceClass, ushort* ServiceName, uint* pcSpnLength, ushort* pszSpn);

		[DllImport(@"ntdsapi", EntryPoint="DsInheritSecurityIdentityW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsInheritSecurityIdentityW(void* hDs, uint Flags, ushort* SrcPrincipal, ushort* DstPrincipal);

		[DllImport(@"ntdsapi", EntryPoint="DsReplicaSyncW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsReplicaSyncW(void* hDS, ushort* NameContext, GUID* pUuidDsaSrc, uint Options);

		[DllImport(@"ntdsapi", EntryPoint="DsMakePasswordCredentialsA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsMakePasswordCredentialsA(sbyte* User, sbyte* Domain, sbyte* Password, void** pAuthIdentity);

		[DllImport(@"ntdsapi", EntryPoint="DsListServersForDomainInSiteA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsListServersForDomainInSiteA(void* hDs, sbyte* domain, sbyte* site, DS_NAME_RESULTA** ppServers);

		[DllImport(@"ntdsapi", EntryPoint="DsMapSchemaGuidsA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsMapSchemaGuidsA(void* hDs, uint cGuids, GUID* rGuids, DS_SCHEMA_GUID_MAPA** ppGuidMap);

		[DllImport(@"ntdsapi", EntryPoint="DsMakeSpnW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsMakeSpnW(ushort* ServiceClass, ushort* ServiceName, ushort* InstanceName, ushort InstancePort, ushort* Referrer, uint* pcSpnLength, ushort* pszSpn);

		[DllImport(@"ntdsapi", EntryPoint="DsReplicaVerifyObjectsW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsReplicaVerifyObjectsW(void* hDS, ushort* NameContext, GUID* pUuidDsaSrc, uint ulOptions);

		[DllImport(@"ntdsapi", EntryPoint="DsCrackSpn2A", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsCrackSpn2A(sbyte* pszSpn, uint cSpn, uint* pcServiceClass, sbyte* ServiceClass, uint* pcServiceName, sbyte* ServiceName, uint* pcInstanceName, sbyte* InstanceName, ushort* pInstancePort);

		[DllImport(@"ntdsapi", EntryPoint="DsBindA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsBindA(sbyte* DomainControllerName, sbyte* DnsDomainName, void** phDS);

		[DllImport(@"ntdsapi", EntryPoint="DsMapSchemaGuidsW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsMapSchemaGuidsW(void* hDs, uint cGuids, GUID* rGuids, DS_SCHEMA_GUID_MAPW** ppGuidMap);

		[DllImport(@"ntdsapi", EntryPoint="DsReplicaConsistencyCheck", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsReplicaConsistencyCheck(void* hDS, DS_KCC_TASKID TaskID, uint dwFlags);

		[DllImport(@"ntdsapi", EntryPoint="DsMakePasswordCredentialsW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsMakePasswordCredentialsW(ushort* User, ushort* Domain, ushort* Password, void** pAuthIdentity);

		[DllImport(@"ntdsapi", EntryPoint="DsBindWithSpnA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsBindWithSpnA(sbyte* DomainControllerName, sbyte* DnsDomainName, void* AuthIdentity, sbyte* ServicePrincipalName, void** phDS);

		[DllImport(@"ntdsapi", EntryPoint="DsReplicaVerifyObjectsA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsReplicaVerifyObjectsA(void* hDS, sbyte* NameContext, GUID* pUuidDsaSrc, uint ulOptions);

		[DllImport(@"ntdsapi", EntryPoint="DsBindW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsBindW(ushort* DomainControllerName, ushort* DnsDomainName, void** phDS);

		[DllImport(@"ntdsapi", EntryPoint="DsFreeDomainControllerInfoA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe void DsFreeDomainControllerInfoA(uint InfoLevel, uint cInfo, void* pInfo);

		[DllImport(@"ntdsapi", EntryPoint="DsRemoveDsServerW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsRemoveDsServerW(void* hDs, ushort* ServerDN, ushort* DomainDN, int* fLastDcInDomain, int fCommit);

		[DllImport(@"ntdsapi", EntryPoint="DsCrackSpnW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsCrackSpnW(ushort* pszSpn, uint* pcServiceClass, ushort* ServiceClass, uint* pcServiceName, ushort* ServiceName, uint* pcInstanceName, ushort* InstanceName, ushort* pInstancePort);

		[DllImport(@"ntdsapi", EntryPoint="DsBindWithSpnW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsBindWithSpnW(ushort* DomainControllerName, ushort* DnsDomainName, void* AuthIdentity, ushort* ServicePrincipalName, void** phDS);

		[DllImport(@"ntdsapi", EntryPoint="DsFreeDomainControllerInfoW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe void DsFreeDomainControllerInfoW(uint InfoLevel, uint cInfo, void* pInfo);

		[DllImport(@"ntdsapi", EntryPoint="DsRemoveDsServerA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsRemoveDsServerA(void* hDs, sbyte* ServerDN, sbyte* DomainDN, int* fLastDcInDomain, int fCommit);

		[DllImport(@"ntdsapi", EntryPoint="DsCrackSpnA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsCrackSpnA(sbyte* pszSpn, uint* pcServiceClass, sbyte* ServiceClass, uint* pcServiceName, sbyte* ServiceName, uint* pcInstanceName, sbyte* InstanceName, ushort* pInstancePort);

		[DllImport(@"ntdsapi", EntryPoint="DsIsMangledRdnValueA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int DsIsMangledRdnValueA(sbyte* pszRdn, uint cRdn, DS_MANGLE_FOR eDsMangleForDesired);

		[DllImport(@"ntdsapi", EntryPoint="DsBindWithCredW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsBindWithCredW(ushort* DomainControllerName, ushort* DnsDomainName, void* AuthIdentity, void** phDS);

		[DllImport(@"ntdsapi", EntryPoint="DsCrackSpn3W", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsCrackSpn3W(ushort* pszSpn, uint cSpn, uint* pcHostName, ushort* HostName, uint* pcInstanceName, ushort* InstanceName, ushort* pPortNumber, uint* pcDomainName, ushort* DomainName, uint* pcRealmName, ushort* RealmName);

		[DllImport(@"ntdsapi", EntryPoint="DsIsMangledDnW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int DsIsMangledDnW(ushort* pszDn, DS_MANGLE_FOR eDsMangleFor);

		[DllImport(@"ntdsapi", EntryPoint="DsListSitesW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsListSitesW(void* hDs, DS_NAME_RESULTW** ppSites);

		[DllImport(@"ntdsapi", EntryPoint="DsIsMangledRdnValueW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int DsIsMangledRdnValueW(ushort* pszRdn, uint cRdn, DS_MANGLE_FOR eDsMangleForDesired);

		[DllImport(@"ntdsapi", EntryPoint="DsFreePasswordCredentials", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe void DsFreePasswordCredentials(void* pAuthIdentity);

		[DllImport(@"ntdsapi", EntryPoint="DsCrackUnquotedMangledRdnA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int DsCrackUnquotedMangledRdnA(sbyte* pszRDN, uint cchRDN, GUID* pGuid, DS_MANGLE_FOR* peDsMangleFor);

		[DllImport(@"ntdsapi", EntryPoint="DsBindWithCredA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsBindWithCredA(sbyte* DomainControllerName, sbyte* DnsDomainName, void* AuthIdentity, void** phDS);

		[DllImport(@"ntdsapi", EntryPoint="DsListServersInSiteW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsListServersInSiteW(void* hDs, ushort* site, DS_NAME_RESULTW** ppServers);

		[DllImport(@"ntdsapi", EntryPoint="DsReplicaAddW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsReplicaAddW(void* hDS, ushort* NameContext, ushort* SourceDsaDn, ushort* TransportDn, ushort* SourceDsaAddress, SCHEDULE* pSchedule, uint Options);

		[DllImport(@"ntdsapi", EntryPoint="DsWriteAccountSpnW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsWriteAccountSpnW(void* hDS, DS_SPN_WRITE_OP Operation, ushort* pszAccount, uint cSpn, ushort** rpszSpn);

		[DllImport(@"ntdsapi", EntryPoint="DsListSitesA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsListSitesA(void* hDs, DS_NAME_RESULTA** ppSites);

		[DllImport(@"ntdsapi", EntryPoint="DsReplicaModifyW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsReplicaModifyW(void* hDS, ushort* NameContext, GUID* pUuidSourceDsa, ushort* TransportDn, ushort* SourceDsaAddress, SCHEDULE* pSchedule, uint ReplicaFlags, uint ModifyFields, uint Options);

		[DllImport(@"ntdsapi", EntryPoint="DsLogEntry", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe int DsLogEntry(uint Flags, sbyte* Format);

		[DllImport(@"ntdsapi", EntryPoint="DsaopBindWithSpn", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsaopBindWithSpn(ushort* DomainControllerName, ushort* DnsDomainName, void* AuthIdentity, uint AuthnSvc, uint AuthnLevel, ushort* ServicePrincipalName, void** phRpc);

		[DllImport(@"ntdsapi", EntryPoint="DsListServersInSiteA", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe uint DsListServersInSiteA(void* hDs, sbyte* site, DS_NAME_RESULTA** ppServers);

		[DllImport(@"ntdsapi", EntryPoint="DsCrackUnquotedMangledRdnW", CallingConvention=CallingConvention.StdCall)]
		public static extern unsafe int DsCrackUnquotedMangledRdnW(ushort* pszRDN, uint cchRDN, GUID* pGuid, DS_MANGLE_FOR* peDsMangleFor);

	}

	#region structs (15)

	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct SCHEDULE_HEADER
	{
		[FieldOffset(0)]
		public uint Type;

		[FieldOffset(4)]
		public uint Offset;
	}

	[StructLayout(LayoutKind.Explicit, Size=20)]
	public struct DS_REPSYNCALL_SYNCA
	{
		[FieldOffset(0)]
		public unsafe sbyte* pszSrcId;

		[FieldOffset(4)]
		public unsafe sbyte* pszDstId;

		[FieldOffset(8)]
		public unsafe sbyte* pszNC;

		[FieldOffset(12)]
		public unsafe GUID* pguidSrc;

		[FieldOffset(16)]
		public unsafe GUID* pguidDst;
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
	public struct DS_REPSYNCALL_ERRINFOW
	{
		[FieldOffset(0)]
		public unsafe ushort* pszSvrId;

		[FieldOffset(4)]
		public DS_REPSYNCALL_ERROR error;

		[FieldOffset(8)]
		public uint dwWin32Err;

		[FieldOffset(12)]
		public unsafe ushort* pszSrcId;
	}

	[StructLayout(LayoutKind.Explicit, Size=12)]
	public struct DS_REPSYNCALL_UPDATEA
	{
		[FieldOffset(0)]
		public DS_REPSYNCALL_EVENT @event;

		[FieldOffset(4)]
		public unsafe DS_REPSYNCALL_ERRINFOA* pErrInfo;

		[FieldOffset(8)]
		public unsafe DS_REPSYNCALL_SYNCA* pSync;
	}

	[StructLayout(LayoutKind.Explicit, Size=20)]
	public struct SCHEDULE
	{
		[FieldOffset(0)]
		public uint Size;

		[FieldOffset(4)]
		public uint Bandwidth;

		[FieldOffset(8)]
		public uint NumberOfSchedules;

		//Fixed-length Array "Schedules[1]". Members can be
		//accessed with (&my_SCHEDULE.Schedules_1)[index]
		[FieldOffset(12)]
		public SCHEDULE_HEADER Schedules_1;
	}

	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct DS_NAME_RESULTW
	{
		[FieldOffset(0)]
		public uint cItems;

		[FieldOffset(4)]
		public unsafe DS_NAME_RESULT_ITEMW* rItems;
	}

	[StructLayout(LayoutKind.Explicit, Size=12)]
	public struct DS_REPSYNCALL_UPDATEW
	{
		[FieldOffset(0)]
		public DS_REPSYNCALL_EVENT @event;

		[FieldOffset(4)]
		public unsafe DS_REPSYNCALL_ERRINFOW* pErrInfo;

		[FieldOffset(8)]
		public unsafe DS_REPSYNCALL_SYNCW* pSync;
	}

	[StructLayout(LayoutKind.Explicit, Size=12)]
	public struct DS_NAME_RESULT_ITEMW
	{
		[FieldOffset(0)]
		public uint status;

		[FieldOffset(4)]
		public unsafe ushort* pDomain;

		[FieldOffset(8)]
		public unsafe ushort* pName;
	}

	[StructLayout(LayoutKind.Explicit, Size=12)]
	public struct DS_NAME_RESULT_ITEMA
	{
		[FieldOffset(0)]
		public uint status;

		[FieldOffset(4)]
		public unsafe sbyte* pDomain;

		[FieldOffset(8)]
		public unsafe sbyte* pName;
	}

	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct DS_NAME_RESULTA
	{
		[FieldOffset(0)]
		public uint cItems;

		[FieldOffset(4)]
		public unsafe DS_NAME_RESULT_ITEMA* rItems;
	}

	[StructLayout(LayoutKind.Explicit, Size=16)]
	public struct DS_REPSYNCALL_ERRINFOA
	{
		[FieldOffset(0)]
		public unsafe sbyte* pszSvrId;

		[FieldOffset(4)]
		public DS_REPSYNCALL_ERROR error;

		[FieldOffset(8)]
		public uint dwWin32Err;

		[FieldOffset(12)]
		public unsafe sbyte* pszSrcId;
	}

	[StructLayout(LayoutKind.Explicit, Size=24)]
	public struct DS_SCHEMA_GUID_MAPW
	{
		[FieldOffset(0)]
		public GUID guid;

		[FieldOffset(16)]
		public uint guidType;

		[FieldOffset(20)]
		public unsafe ushort* pName;
	}

	[StructLayout(LayoutKind.Explicit, Size=24)]
	public struct DS_SCHEMA_GUID_MAPA
	{
		[FieldOffset(0)]
		public GUID guid;

		[FieldOffset(16)]
		public uint guidType;

		[FieldOffset(20)]
		public unsafe sbyte* pName;
	}

	[StructLayout(LayoutKind.Explicit, Size=20)]
	public struct DS_REPSYNCALL_SYNCW
	{
		[FieldOffset(0)]
		public unsafe ushort* pszSrcId;

		[FieldOffset(4)]
		public unsafe ushort* pszDstId;

		[FieldOffset(8)]
		public unsafe ushort* pszNC;

		[FieldOffset(12)]
		public unsafe GUID* pguidSrc;

		[FieldOffset(16)]
		public unsafe GUID* pguidDst;
	}
	#endregion

	#region enums (9)

	public enum DS_SPN_NAME_TYPE : int
	{
		DS_SPN_DNS_HOST = 0,
		DS_SPN_DN_HOST = 1,
		DS_SPN_NB_HOST = 2,
		DS_SPN_DOMAIN = 3,
		DS_SPN_NB_DOMAIN = 4,
		DS_SPN_SERVICE = 5
	}

	public enum DS_SPN_WRITE_OP : int
	{
		DS_SPN_ADD_SPN_OP = 0,
		DS_SPN_REPLACE_SPN_OP = 1,
		DS_SPN_DELETE_SPN_OP = 2
	}

	public enum DS_REPSYNCALL_ERROR : int
	{
		DS_REPSYNCALL_WIN32_ERROR_CONTACTING_SERVER = 0,
		DS_REPSYNCALL_WIN32_ERROR_REPLICATING = 1,
		DS_REPSYNCALL_SERVER_UNREACHABLE = 2
	}

	public enum DS_REPL_INFO_TYPE : int
	{
		DS_REPL_INFO_NEIGHBORS = 0,
		DS_REPL_INFO_CURSORS_FOR_NC = 1,
		DS_REPL_INFO_METADATA_FOR_OBJ = 2,
		DS_REPL_INFO_KCC_DSA_CONNECT_FAILURES = 3,
		DS_REPL_INFO_KCC_DSA_LINK_FAILURES = 4,
		DS_REPL_INFO_PENDING_OPS = 5,
		DS_REPL_INFO_METADATA_FOR_ATTR_VALUE = 6,
		DS_REPL_INFO_CURSORS_2_FOR_NC = 7,
		DS_REPL_INFO_CURSORS_3_FOR_NC = 8,
		DS_REPL_INFO_METADATA_2_FOR_OBJ = 9,
		DS_REPL_INFO_METADATA_2_FOR_ATTR_VALUE = 10,
		DS_REPL_INFO_TYPE_MAX = 11
	}

	public enum DS_NAME_FLAGS : int
	{
		DS_NAME_NO_FLAGS = 0,
		DS_NAME_FLAG_SYNTACTICAL_ONLY = 1,
		DS_NAME_FLAG_EVAL_AT_DC = 2,
		DS_NAME_FLAG_GCVERIFY = 4,
		DS_NAME_FLAG_TRUST_REFERRAL = 8
	}

	public enum DS_KCC_TASKID : int
	{
		DS_KCC_TASKID_UPDATE_TOPOLOGY = 0
	}

	public enum DS_MANGLE_FOR : int
	{
		DS_MANGLE_UNKNOWN = 0,
		DS_MANGLE_OBJECT_RDN_FOR_DELETION = 1,
		DS_MANGLE_OBJECT_RDN_FOR_NAME_CONFLICT = 2
	}

	public enum DS_REPSYNCALL_EVENT : int
	{
		DS_REPSYNCALL_EVENT_ERROR = 0,
		DS_REPSYNCALL_EVENT_SYNC_STARTED = 1,
		DS_REPSYNCALL_EVENT_SYNC_COMPLETED = 2,
		DS_REPSYNCALL_EVENT_FINISHED = 3
	}

	public enum DS_NAME_FORMAT : int
	{
		DS_UNKNOWN_NAME = 0,
		DS_FQDN_1779_NAME = 1,
		DS_NT4_ACCOUNT_NAME = 2,
		DS_DISPLAY_NAME = 3,
		DS_UNIQUE_ID_NAME = 6,
		DS_CANONICAL_NAME = 7,
		DS_USER_PRINCIPAL_NAME = 8,
		DS_CANONICAL_NAME_EX = 9,
		DS_SERVICE_PRINCIPAL_NAME = 10,
		DS_SID_OR_SID_HISTORY_NAME = 11,
		DS_DNS_DOMAIN_NAME = 12
	}
	#endregion

	#region delegates (2)
	//note: Delegates marshalled from Function Ptrs pointing to 
	//	unmanaged code cannot be called from C# in version 7.0
	public unsafe delegate int GeneratedDelegate2(void* arg1, DS_REPSYNCALL_UPDATEW* arg2);
	public unsafe delegate int GeneratedDelegate1(void* arg1, DS_REPSYNCALL_UPDATEA* arg2);

	#region delegate helper functions
	class Helpers
	{
		//These helper functions are generated as a workaround to allow
		//	the conversion of a Delegate to void *.  This allows the user
		//	to avoid dealing with the Marshalling of delegates when
		//	allowing unmanaged code to call a C# function.
	
		public static unsafe void* DelegateToPtr(GeneratedDelegate2 d){ return lstrcpyn(d, null, 0); }
		[DllImport("kernel32")] private static unsafe extern void* lstrcpyn(
			[MarshalAs(UnmanagedType.FunctionPtr)] GeneratedDelegate2 d, void* pSrc, int maxLength);
	
		public static unsafe void* DelegateToPtr(GeneratedDelegate1 d){ return lstrcpyn(d, null, 0); }
		[DllImport("kernel32")] private static unsafe extern void* lstrcpyn(
			[MarshalAs(UnmanagedType.FunctionPtr)] GeneratedDelegate1 d, void* pSrc, int maxLength);
	}
	#endregion
	#endregion
}

//comletion time: 5:16:23 PM
