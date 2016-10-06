using System;
using System.Runtime.InteropServices;

//generated on 6/5/2003 at 2:40:37 PM
namespace LDAP.Wldap32
{
	class Wldap32
	{
		//245 functions were generated: C:\DBG\PDB2CS\src\release\wldap32.dll

		[DllImport(@"wldap32", EntryPoint="ldap_abandon", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_abandon(LDAP* ExternalHandle, uint msgid);

		[DllImport(@"wldap32", EntryPoint="ldap_control_free", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_control_free(LDAPControlA* Control);

		[DllImport(@"wldap32", EntryPoint="ldap_dn2ufn", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe sbyte* ldap_dn2ufn(sbyte* dn);

		[DllImport(@"wldap32", EntryPoint="ber_bvecfree", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe void ber_bvecfree(BERVAL** pBerVal);

		[DllImport(@"wldap32", EntryPoint="ldap_encode_sort_controlA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_encode_sort_controlA(LDAP* ExternalHandle, LDAPSortKeyA** SortKeys, LDAPControlA* Control, byte Criticality);

		[DllImport(@"wldap32", EntryPoint="ldap_delete_ext_sW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_delete_ext_sW(LDAP* ExternalHandle, ushort* dn, LDAPControlW** ServerControls, LDAPControlW** ClientControls);

		[DllImport(@"wldap32", EntryPoint="ldap_compare", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_compare(LDAP* ExternalHandle, sbyte* DistinguishedName, sbyte* Attribute, sbyte* Value);

		[DllImport(@"wldap32", EntryPoint="ldap_addW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_addW(LDAP* ExternalHandle, ushort* DistinguishedName, LDAPModW** AttributeList);

		[DllImport(@"wldap32", EntryPoint="ldap_encode_sort_controlW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_encode_sort_controlW(LDAP* ExternalHandle, LDAPSortKeyW** SortKeys, LDAPControlW* Control, byte Criticality);

		[DllImport(@"wldap32", EntryPoint="ldap_modify_s", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_modify_s(LDAP* ExternalHandle, sbyte* DistinguishedName, LDAPModA** AttributeList);

		[DllImport(@"wldap32", EntryPoint="ldap_startup", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_startup(LDAP_VERSION_INFO* version, void** hInstance);

		[DllImport(@"wldap32", EntryPoint="ldap_addA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_addA(LDAP* ExternalHandle, sbyte* DistinguishedName, LDAPModA** AttributeList);

		[DllImport(@"wldap32", EntryPoint="ldap_compare_extA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_compare_extA(LDAP* ExternalHandle, sbyte* DistinguishedName, sbyte* Attr, sbyte* Value, BERVAL* Data, LDAPControlA** ServerControls, LDAPControlA** ClientControls, uint* MessageNumber);

		[DllImport(@"wldap32", EntryPoint="ldap_add_sW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_add_sW(LDAP* ExternalHandle, ushort* DistinguishedName, LDAPModW** AttributeList);

		[DllImport(@"wldap32", EntryPoint="ldap_get_values_len", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe BERVAL** ldap_get_values_len(LDAP* ExternalHandle, LDAPMessage* Message, sbyte* Attribute);

		[DllImport(@"wldap32", EntryPoint="ldap_create_sort_control", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_create_sort_control(LDAP* ExternalHandle, LDAPSortKeyA** SortKeys, byte IsCritical, LDAPControlA** Control);

		[DllImport(@"wldap32", EntryPoint="ldap_rename_ext_sW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_rename_ext_sW(LDAP* ExternalHandle, ushort* DistinguishedName, ushort* NewRDN, ushort* NewParent, int DeleteOldRdn, LDAPControlW** ServerControls, LDAPControlW** ClientControls);

		[DllImport(@"wldap32", EntryPoint="ldap_add_sA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_add_sA(LDAP* ExternalHandle, sbyte* DistinguishedName, LDAPModA** AttributeList);

		[DllImport(@"wldap32", EntryPoint="ldap_add_ext", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_add_ext(LDAP* ExternalHandle, sbyte* DistinguishedName, LDAPModA** AttributeList, LDAPControlA** ServerControls, LDAPControlA** ClientControls, uint* MessageNumber);

		[DllImport(@"wldap32", EntryPoint="ldap_compare_extW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_compare_extW(LDAP* ExternalHandle, ushort* DistinguishedName, ushort* Attr, ushort* Value, BERVAL* Data, LDAPControlW** ServerControls, LDAPControlW** ClientControls, uint* MessageNumber);

		[DllImport(@"wldap32", EntryPoint="ldap_start_tls_sA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_start_tls_sA(LDAP* ExternalHandle, uint* ServerReturnValue, LDAPMessage** result, LDAPControlA** ServerControls, LDAPControlA** ClientControls);

		[DllImport(@"wldap32", EntryPoint="ldap_connect", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_connect(LDAP* ExternalHandle, LDAP_TIMEVAL* timeout);

		[DllImport(@"wldap32", EntryPoint="ldap_modrdn2_s", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_modrdn2_s(LDAP* ExternalHandle, sbyte* DistinguishedName, sbyte* NewDistinguishedName, int DeleteOldRdn);

		[DllImport(@"wldap32", EntryPoint="ldap_get_next_page", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_get_next_page(LDAP* ExternalHandle, LDAPSearch* SearchBlock, uint PageSize, uint* MessageNumber);

		[DllImport(@"wldap32", EntryPoint="ldap_perror", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe void ldap_perror(/*fn ptr->delegate: DBGPRINT*/ void* DebugPrintRoutine);

		[DllImport(@"wldap32", EntryPoint="ldap_search_sA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_search_sA(LDAP* ExternalHandle, sbyte* DistinguishedName, uint ScopeOfSearch, sbyte* SearchFilter, sbyte** AttributeList, uint AttributesOnly, LDAPMessage** Results);

		[DllImport(@"wldap32", EntryPoint="ldap_count_values", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_count_values(sbyte** vals);

		[DllImport(@"wldap32", EntryPoint="ldap_parse_extended_resultA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_parse_extended_resultA(LDAP* ExternalHandle, LDAPMessage* ResultMessage, sbyte** ResultOID, BERVAL** ResultData, byte Freeit);

		[DllImport(@"wldap32", EntryPoint="ber_flatten", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe int ber_flatten(BerElement* pBerElement, BERVAL** pBerVal);

		[DllImport(@"wldap32", EntryPoint="ldap_first_attribute", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe sbyte* ldap_first_attribute(LDAP* ExternalHandle, LDAPMessage* Message, BerElement** OpaqueResults);

		[DllImport(@"wldap32", EntryPoint="ldap_modrdn2", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_modrdn2(LDAP* ExternalHandle, sbyte* DistinguishedName, sbyte* NewDistinguishedName, int DeleteOldRdn);

		[DllImport(@"wldap32", EntryPoint="ldap_add", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_add(LDAP* ExternalHandle, sbyte* DistinguishedName, LDAPModA** AttributeList);

		[DllImport(@"wldap32", EntryPoint="ldap_search_extA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_search_extA(LDAP* ExternalHandle, sbyte* DistinguishedName, uint ScopeOfSearch, sbyte* SearchFilter, sbyte** AttributeList, uint AttributesOnly, LDAPControlA** ServerControls, LDAPControlA** ClientControls, uint TimeLimit, uint SizeLimit, uint* MessageNumber);

		[DllImport(@"wldap32", EntryPoint="ldap_simple_bind_sA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_simple_bind_sA(LDAP* ExternalHandle, sbyte* DistName, sbyte* PassWord);

		[DllImport(@"wldap32", EntryPoint="ber_first_element", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ber_first_element(BerElement* pBerElement, uint* pLen, sbyte** pOpaque);

		[DllImport(@"wldap32", EntryPoint="ldap_delete_s", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_delete_s(LDAP* ExternalHandle, sbyte* DistinguishedName);

		[DllImport(@"wldap32", EntryPoint="ldap_compare_sW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_compare_sW(LDAP* ExternalHandle, ushort* DistinguishedName, ushort* Attribute, ushort* Value);

		[DllImport(@"wldap32", EntryPoint="ldap_parse_sort_controlA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_parse_sort_controlA(LDAP* ExternalHandle, LDAPControlA** Control, uint* Result, sbyte** Attribute);

		[DllImport(@"wldap32", EntryPoint="ldap_modifyW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_modifyW(LDAP* ExternalHandle, ushort* DistinguishedName, LDAPModW** AttributeList);

		[DllImport(@"wldap32", EntryPoint="ldap_parse_result", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_parse_result(LDAP* ExternalHandle, LDAPMessage* ResultMessage, uint* ReturnCode, sbyte** MatchedDNs, sbyte** ErrorMessage, sbyte*** Referrals, LDAPControlA*** ServerControls, byte Freeit);

		[DllImport(@"wldap32", EntryPoint="ldap_controls_freeA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_controls_freeA(LDAPControlW** Controls);

		[DllImport(@"wldap32", EntryPoint="ldap_first_reference", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe LDAPMessage* ldap_first_reference(LDAP* ExternalHandle, LDAPMessage* Results);

		[DllImport(@"wldap32", EntryPoint="ldap_simple_bind_sW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_simple_bind_sW(LDAP* ExternalHandle, ushort* DistName, ushort* PassWord);

		[DllImport(@"wldap32", EntryPoint="ldap_delete_ext", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_delete_ext(LDAP* ExternalHandle, sbyte* DistinguishedName, LDAPControlA** ServerControls, LDAPControlA** ClientControls, uint* MessageNumber);

		[DllImport(@"wldap32", EntryPoint="ldap_extended_operation_sW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_extended_operation_sW(LDAP* ExternalHandle, ushort* Oid, BERVAL* Data, LDAPControlW** ServerControls, LDAPControlW** ClientControls, ushort** ReturnedOid, BERVAL** ReturnedData);

		[DllImport(@"wldap32", EntryPoint="ldap_err2stringA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe sbyte* ldap_err2stringA(uint err);

		[DllImport(@"wldap32", EntryPoint="ldap_unbind_s", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_unbind_s(LDAP* ExternalHandle);

		[DllImport(@"wldap32", EntryPoint="ldap_controls_freeW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_controls_freeW(LDAPControlW** Controls);

		[DllImport(@"wldap32", EntryPoint="ldap_add_extA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_add_extA(LDAP* ExternalHandle, sbyte* DistinguishedName, LDAPModA** AttributeList, LDAPControlA** ServerControls, LDAPControlA** ClientControls, uint* MessageNumber);

		[DllImport(@"wldap32", EntryPoint="ldap_sslinitA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe LDAP* ldap_sslinitA(sbyte* HostName, uint PortNumber, int Secure);

		[DllImport(@"wldap32", EntryPoint="ldap_err2stringW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe ushort* ldap_err2stringW(uint err);

		[DllImport(@"wldap32", EntryPoint="ldap_search_s", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_search_s(LDAP* ExternalHandle, sbyte* DistinguishedName, uint ScopeOfSearch, sbyte* SearchFilter, sbyte** AttributeList, uint AttributesOnly, LDAPMessage** Results);

		[DllImport(@"wldap32", EntryPoint="ldap_delete_sW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_delete_sW(LDAP* ExternalHandle, ushort* DistinguishedName);

		[DllImport(@"wldap32", EntryPoint="ldap_get_next_page_s", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_get_next_page_s(LDAP* ExternalHandle, LDAPSearch* SearchHandle, LDAP_TIMEVAL* timeout, uint PageSize, uint* TotalCount, LDAPMessage** Results);

		[DllImport(@"wldap32", EntryPoint="ldap_extended_operation_sA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_extended_operation_sA(LDAP* ExternalHandle, sbyte* Oid, BERVAL* Data, LDAPControlA** ServerControls, LDAPControlA** ClientControls, sbyte** ReturnedOid, BERVAL** ReturnedData);

		[DllImport(@"wldap32", EntryPoint="ldap_get_option", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_get_option(LDAP* ExternalHandle, int option, void* outvalue);

		[DllImport(@"wldap32", EntryPoint="ldap_rename_ext_sA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_rename_ext_sA(LDAP* ExternalHandle, sbyte* DistinguishedName, sbyte* NewRDN, sbyte* NewParent, int DeleteOldRdn, LDAPControlA** ServerControls, LDAPControlA** ClientControls);

		[DllImport(@"wldap32", EntryPoint="ldap_ufn2dnW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_ufn2dnW(ushort* ufn, ushort** pDn);

		[DllImport(@"wldap32", EntryPoint="ldap_dn2ufnW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe ushort* ldap_dn2ufnW(ushort* dn);

		[DllImport(@"wldap32", EntryPoint="ldap_get_optionW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_get_optionW(LDAP* ExternalHandle, int option, void* outvalue);

		[DllImport(@"wldap32", EntryPoint="ldap_openW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe LDAP* ldap_openW(ushort* HostName, uint PortNumber);

		[DllImport(@"wldap32", EntryPoint="ldap_add_extW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_add_extW(LDAP* ExternalHandle, ushort* DistinguishedName, LDAPModW** AttributeList, LDAPControlW** ServerControls, LDAPControlW** ClientControls, uint* MessageNumber);

		[DllImport(@"wldap32", EntryPoint="ldap_get_dn", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe sbyte* ldap_get_dn(LDAP* ExternalHandle, LDAPMessage* LdapMsg);

		[DllImport(@"wldap32", EntryPoint="ldap_free_controlsA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_free_controlsA(LDAPControlW** Controls);

		[DllImport(@"wldap32", EntryPoint="ldap_dn2ufnA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe sbyte* ldap_dn2ufnA(sbyte* dn);

		[DllImport(@"wldap32", EntryPoint="ldap_rename_extW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_rename_extW(LDAP* ExternalHandle, ushort* DistinguishedName, ushort* NewRDN, ushort* NewParent, int DeleteOldRdn, LDAPControlW** ServerControls, LDAPControlW** ClientControls, uint* MessageNumber);

		[DllImport(@"wldap32", EntryPoint="ldap_bindW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_bindW(LDAP* ExternalHandle, ushort* DistName, ushort* Cred, uint Method);

		[DllImport(@"wldap32", EntryPoint="ldap_first_entry", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe LDAPMessage* ldap_first_entry(LDAP* ExternalHandle, LDAPMessage* Results);

		[DllImport(@"wldap32", EntryPoint="ldap_count_references", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_count_references(LDAP* ExternalHandle, LDAPMessage* entry);

		[DllImport(@"wldap32", EntryPoint="ldap_search_abandon_page", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_search_abandon_page(LDAP* ExternalHandle, LDAPSearch* SearchBlock);

		[DllImport(@"wldap32", EntryPoint="ldap_search", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_search(LDAP* ExternalHandle, sbyte* DistinguishedName, uint ScopeOfSearch, sbyte* SearchFilter, sbyte** AttributeList, uint AttributesOnly);

		[DllImport(@"wldap32", EntryPoint="ldap_free_controlsW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_free_controlsW(LDAPControlW** Controls);

		[DllImport(@"wldap32", EntryPoint="ldap_rename_extA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_rename_extA(LDAP* ExternalHandle, sbyte* DistinguishedName, sbyte* NewRDN, sbyte* NewParent, int DeleteOldRdn, LDAPControlA** ServerControls, LDAPControlA** ClientControls, uint* MessageNumber);

		[DllImport(@"wldap32", EntryPoint="ldap_value_free", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_value_free(sbyte** vals);

		[DllImport(@"wldap32", EntryPoint="ldap_bind_sW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_bind_sW(LDAP* ExternalHandle, ushort* DistName, ushort* Cred, uint Method);

		[DllImport(@"wldap32", EntryPoint="ldap_rename_ext_s", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_rename_ext_s(LDAP* ExternalHandle, sbyte* DistinguishedName, sbyte* NewRDN, sbyte* NewParent, int DeleteOldRdn, LDAPControlA** ServerControls, LDAPControlA** ClientControls);

		[DllImport(@"wldap32", EntryPoint="ldap_delete", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_delete(LDAP* ExternalHandle, sbyte* DistinguishedName);

		[DllImport(@"wldap32", EntryPoint="ldap_bindA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_bindA(LDAP* ExternalHandle, sbyte* DistName, sbyte* Cred, uint Method);

		[DllImport(@"wldap32", EntryPoint="ldap_parse_page_control", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_parse_page_control(LDAP* ExternalHandle, LDAPControlA** ServerControls, uint* TotalCount, BERVAL** Cookie);

		[DllImport(@"wldap32", EntryPoint="ldap_bind_sA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_bind_sA(LDAP* ExternalHandle, sbyte* DistName, sbyte* Cred, uint Method);

		[DllImport(@"wldap32", EntryPoint="ldap_compare_sA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_compare_sA(LDAP* ExternalHandle, sbyte* DistinguishedName, sbyte* Attribute, sbyte* Value);

		[DllImport(@"wldap32", EntryPoint="ldap_open", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe LDAP* ldap_open(sbyte* HostName, uint PortNumber);

		[DllImport(@"wldap32", EntryPoint="ldap_search_ext_sA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_search_ext_sA(LDAP* ExternalHandle, sbyte* DistinguishedName, uint ScopeOfSearch, sbyte* SearchFilter, sbyte** AttributeList, uint AttributesOnly, LDAPControlA** ServerControls, LDAPControlA** ClientControls, LDAP_TIMEVAL* timeout, uint SizeLimit, LDAPMessage** Results);

		[DllImport(@"wldap32", EntryPoint="ldap_parse_vlv_controlA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe int ldap_parse_vlv_controlA(LDAP* ExternalHandle, LDAPControlA** Control, uint* TargetPos, uint* ListCount, BERVAL** Context, int* ErrCode);

		[DllImport(@"wldap32", EntryPoint="ldap_result2error", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_result2error(LDAP* ExternalHandle, LDAPMessage* res, uint FreeIt);

		[DllImport(@"wldap32", EntryPoint="ldap_modify_ext_s", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_modify_ext_s(LDAP* ExternalHandle, sbyte* DistinguishedName, LDAPModA** AttributeList, LDAPControlA** ServerControls, LDAPControlA** ClientControls);

		[DllImport(@"wldap32", EntryPoint="ldap_delete_sA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_delete_sA(LDAP* ExternalHandle, sbyte* DistinguishedName);

		[DllImport(@"wldap32", EntryPoint="ldap_openA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe LDAP* ldap_openA(sbyte* HostName, uint PortNumber);

		[DllImport(@"wldap32", EntryPoint="ber_bvfree", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe void ber_bvfree(BERVAL* bv);

		[DllImport(@"wldap32", EntryPoint="ldap_escape_filter_elementA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_escape_filter_elementA(sbyte* sourceFilterElement, uint sourceLength, sbyte* destFilterElement, uint destLength);

		[DllImport(@"wldap32", EntryPoint="ldap_parse_sort_controlW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_parse_sort_controlW(LDAP* ExternalHandle, LDAPControlW** Control, uint* Result, ushort** Attribute);

		[DllImport(@"wldap32", EntryPoint="ldap_memfree", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe void ldap_memfree(sbyte* Block);

		[DllImport(@"wldap32", EntryPoint="ldap_parse_vlv_controlW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe int ldap_parse_vlv_controlW(LDAP* ExternalHandle, LDAPControlW** Control, uint* TargetPos, uint* ListCount, BERVAL** Context, int* ErrCode);

		[DllImport(@"wldap32", EntryPoint="ldap_modify_extW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_modify_extW(LDAP* ExternalHandle, ushort* DistinguishedName, LDAPModW** AttributeList, LDAPControlW** ServerControls, LDAPControlW** ClientControls, uint* MessageNumber);

		[DllImport(@"wldap32", EntryPoint="ldap_compare_ext", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_compare_ext(LDAP* ExternalHandle, sbyte* DistinguishedName, sbyte* Attr, sbyte* Value, BERVAL* Data, LDAPControlA** ServerControls, LDAPControlA** ClientControls, uint* MessageNumber);

		[DllImport(@"wldap32", EntryPoint="ldap_search_ext_sW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_search_ext_sW(LDAP* ExternalHandle, ushort* DistinguishedName, uint ScopeOfSearch, ushort* SearchFilter, ushort** AttributeList, uint AttributesOnly, LDAPControlW** ServerControls, LDAPControlW** ClientControls, LDAP_TIMEVAL* timeout, uint SizeLimit, LDAPMessage** Results);

		[DllImport(@"wldap32", EntryPoint="ldap_sasl_bindW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe int ldap_sasl_bindW(LDAP* ExternalHandle, ushort* DistName, ushort* AuthMechanism, BERVAL* cred, LDAPControlW** ServerCtrls, LDAPControlW** ClientCtrls, int* MessageNumber);

		[DllImport(@"wldap32", EntryPoint="ldap_add_ext_sW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_add_ext_sW(LDAP* ExternalHandle, ushort* DistinguishedName, LDAPModW** AttributeList, LDAPControlW** ServerControls, LDAPControlW** ClientControls);

		[DllImport(@"wldap32", EntryPoint="ldap_escape_filter_elementW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_escape_filter_elementW(sbyte* sourceFilterElement, uint sourceLength, ushort* destFilterElement, uint destLength);

		[DllImport(@"wldap32", EntryPoint="ldap_control_freeW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_control_freeW(LDAPControlW* Control);

		[DllImport(@"wldap32", EntryPoint="ldap_explode_dnA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe sbyte** ldap_explode_dnA(sbyte* dn, uint notypes);

		[DllImport(@"wldap32", EntryPoint="ldap_create_page_control", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_create_page_control(LDAP* ExternalHandle, uint PageSize, BERVAL* Cookie, byte IsCritical, LDAPControlA** Control);

		[DllImport(@"wldap32", EntryPoint="ldap_modify_extA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_modify_extA(LDAP* ExternalHandle, sbyte* DistinguishedName, LDAPModA** AttributeList, LDAPControlA** ServerControls, LDAPControlA** ClientControls, uint* MessageNumber);

		[DllImport(@"wldap32", EntryPoint="LdapGetLastError", CallingConvention=CallingConvention.Cdecl)]
		public static extern uint LdapGetLastError();

		[DllImport(@"wldap32", EntryPoint="ldap_count_valuesW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_count_valuesW(sbyte** vals);

		[DllImport(@"wldap32", EntryPoint="ldap_control_freeA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_control_freeA(LDAPControlA* Control);

		[DllImport(@"wldap32", EntryPoint="ldap_explode_dnW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe ushort** ldap_explode_dnW(ushort* dn, uint notypes);

		[DllImport(@"wldap32", EntryPoint="ldap_modrdn_s", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_modrdn_s(LDAP* ExternalHandle, sbyte* DistinguishedName, sbyte* NewDistinguishedName);

		[DllImport(@"wldap32", EntryPoint="ldap_sslinit", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe LDAP* ldap_sslinit(sbyte* HostName, uint PortNumber, int Secure);

		[DllImport(@"wldap32", EntryPoint="ldap_count_valuesA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_count_valuesA(sbyte** vals);

		[DllImport(@"wldap32", EntryPoint="ldap_get_values_lenW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe BERVAL** ldap_get_values_lenW(LDAP* ExternalHandle, LDAPMessage* Message, ushort* Attribute);

		[DllImport(@"wldap32", EntryPoint="ldap_get_optionA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_get_optionA(LDAP* ExternalHandle, int option, void* outvalue);

		[DllImport(@"wldap32", EntryPoint="ldap_parse_extended_resultW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_parse_extended_resultW(LDAP* ExternalHandle, LDAPMessage* ResultMessage, ushort** ResultOID, BERVAL** ResultData, byte Freeit);

		[DllImport(@"wldap32", EntryPoint="ldap_delete_ext_s", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_delete_ext_s(LDAP* ExternalHandle, sbyte* DistinguishedName, LDAPControlA** ServerControls, LDAPControlA** ClientControls);

		[DllImport(@"wldap32", EntryPoint="ber_printf", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe int ber_printf(BerElement* pBerElement, sbyte* fmt, sbyte* pchar);

		[DllImport(@"wldap32", EntryPoint="ldap_parse_sort_control", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_parse_sort_control(LDAP* ExternalHandle, LDAPControlA** Control, uint* Result, sbyte** Attribute);

		[DllImport(@"wldap32", EntryPoint="ldap_set_optionA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_set_optionA(LDAP* ExternalHandle, int option, void* invalue);

		[DllImport(@"wldap32", EntryPoint="ldap_modrdn_sA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_modrdn_sA(LDAP* ExternalHandle, sbyte* DistinguishedName, sbyte* NewDistinguishedName);

		[DllImport(@"wldap32", EntryPoint="cldap_open", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe LDAP* cldap_open(sbyte* HostName, uint PortNumber);

		[DllImport(@"wldap32", EntryPoint="ldap_search_stW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_search_stW(LDAP* ExternalHandle, ushort* DistinguishedName, uint ScopeOfSearch, ushort* SearchFilter, ushort** AttributeList, uint AttributesOnly, LDAP_TIMEVAL* TimeOut, LDAPMessage** Results);

		[DllImport(@"wldap32", EntryPoint="ber_bvdup", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe BERVAL* ber_bvdup(BERVAL* pBerVal);

		[DllImport(@"wldap32", EntryPoint="ldap_close_extended_op", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_close_extended_op(LDAP* ExternalHandle, uint MessageNumber);

		[DllImport(@"wldap32", EntryPoint="ldap_search_ext", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_search_ext(LDAP* ExternalHandle, sbyte* DistinguishedName, uint ScopeOfSearch, sbyte* SearchFilter, sbyte** AttributeList, uint AttributesOnly, LDAPControlA** ServerControls, LDAPControlA** ClientControls, uint TimeLimit, uint SizeLimit, uint* MessageNumber);

		[DllImport(@"wldap32", EntryPoint="ldap_get_values_lenA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe BERVAL** ldap_get_values_lenA(LDAP* ExternalHandle, LDAPMessage* Message, sbyte* Attribute);

		[DllImport(@"wldap32", EntryPoint="ldap_set_optionW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_set_optionW(LDAP* ExternalHandle, int option, void* invalue);

		[DllImport(@"wldap32", EntryPoint="ldap_sslinitW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe LDAP* ldap_sslinitW(ushort* HostName, uint PortNumber, int Secure);

		[DllImport(@"wldap32", EntryPoint="ldap_search_sW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_search_sW(LDAP* ExternalHandle, ushort* DistinguishedName, uint ScopeOfSearch, ushort* SearchFilter, ushort** AttributeList, uint AttributesOnly, LDAPMessage** Results);

		[DllImport(@"wldap32", EntryPoint="ldap_controls_free", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_controls_free(LDAPControlW** Controls);

		[DllImport(@"wldap32", EntryPoint="ldap_bind", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_bind(LDAP* ExternalHandle, sbyte* DistName, sbyte* Cred, uint Method);

		[DllImport(@"wldap32", EntryPoint="ber_peek_tag", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ber_peek_tag(BerElement* pBerElement, uint* pLen);

		[DllImport(@"wldap32", EntryPoint="ldap_get_paged_count", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_get_paged_count(LDAP* ExternalHandle, LDAPSearch* SearchBlock, uint* TotalCount, LDAPMessage* Results);

		[DllImport(@"wldap32", EntryPoint="ldap_modrdn", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_modrdn(LDAP* ExternalHandle, sbyte* DistinguishedName, sbyte* NewDistinguishedName);

		[DllImport(@"wldap32", EntryPoint="ldap_search_init_pageW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe LDAPSearch* ldap_search_init_pageW(LDAP* ExternalHandle, ushort* DistinguishedName, uint ScopeOfSearch, ushort* SearchFilter, ushort** AttributeList, uint AttributesOnly, LDAPControlW** ServerControls, LDAPControlW** ClientControls, uint PageTimeLimit, uint TotalSizeLimit, LDAPSortKeyW** SortKeys);

		[DllImport(@"wldap32", EntryPoint="ldap_count_entries", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_count_entries(LDAP* ExternalHandle, LDAPMessage* res);

		[DllImport(@"wldap32", EntryPoint="ldap_compare_ext_sA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_compare_ext_sA(LDAP* ExternalHandle, sbyte* DistinguishedName, sbyte* Attr, sbyte* Value, BERVAL* Data, LDAPControlA** ServerControls, LDAPControlA** ClientControls);

		[DllImport(@"wldap32", EntryPoint="ldap_ufn2dn", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_ufn2dn(sbyte* ufn, sbyte** pDn);

		[DllImport(@"wldap32", EntryPoint="ldap_conn_from_msg", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe LDAP* ldap_conn_from_msg(LDAP* PrimaryConn, LDAPMessage* res);

		[DllImport(@"wldap32", EntryPoint="ldap_search_init_pageA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe LDAPSearch* ldap_search_init_pageA(LDAP* ExternalHandle, sbyte* DistinguishedName, uint ScopeOfSearch, sbyte* SearchFilter, sbyte** AttributeList, uint AttributesOnly, LDAPControlA** ServerControls, LDAPControlA** ClientControls, uint PageTimeLimit, uint TotalSizeLimit, LDAPSortKeyA** SortKeys);

		[DllImport(@"wldap32", EntryPoint="ldap_compareW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_compareW(LDAP* ExternalHandle, ushort* DistinguishedName, ushort* Attribute, ushort* Value);

		[DllImport(@"wldap32", EntryPoint="ldap_free_controls", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_free_controls(LDAPControlW** Controls);

		[DllImport(@"wldap32", EntryPoint="ldap_extended_operationW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_extended_operationW(LDAP* ExternalHandle, ushort* Oid, BERVAL* Data, LDAPControlW** ServerControls, LDAPControlW** ClientControls, uint* MessageNumber);

		[DllImport(@"wldap32", EntryPoint="ldap_modrdn2_sW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_modrdn2_sW(LDAP* ExternalHandle, ushort* DistinguishedName, ushort* NewDistinguishedName, int DeleteOldRdn);

		[DllImport(@"wldap32", EntryPoint="ldap_msgfree", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_msgfree(LDAPMessage* res);

		[DllImport(@"wldap32", EntryPoint="ldap_compare_ext_sW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_compare_ext_sW(LDAP* ExternalHandle, ushort* DistinguishedName, ushort* Attr, ushort* Value, BERVAL* Data, LDAPControlW** ServerControls, LDAPControlW** ClientControls);

		[DllImport(@"wldap32", EntryPoint="ldap_compareA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_compareA(LDAP* ExternalHandle, sbyte* DistinguishedName, sbyte* Attribute, sbyte* Value);

		[DllImport(@"wldap32", EntryPoint="ldap_extended_operationA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_extended_operationA(LDAP* ExternalHandle, sbyte* Oid, BERVAL* Data, LDAPControlA** ServerControls, LDAPControlA** ClientControls, uint* MessageNumber);

		[DllImport(@"wldap32", EntryPoint="cldap_openA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe LDAP* cldap_openA(sbyte* HostName, uint PortNumber);

		[DllImport(@"wldap32", EntryPoint="ldap_ufn2dnA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_ufn2dnA(sbyte* ufn, sbyte** pDn);

		[DllImport(@"wldap32", EntryPoint="LdapMapErrorToWin32", CallingConvention=CallingConvention.Cdecl)]
		public static extern uint LdapMapErrorToWin32(uint LdapError);

		[DllImport(@"wldap32", EntryPoint="ber_init", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe BerElement* ber_init(BERVAL* pBerVal);

		[DllImport(@"wldap32", EntryPoint="ldap_modrdn2_sA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_modrdn2_sA(LDAP* ExternalHandle, sbyte* DistinguishedName, sbyte* NewDistinguishedName, int DeleteOldRdn);

		[DllImport(@"wldap32", EntryPoint="ldap_initA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe LDAP* ldap_initA(sbyte* HostName, uint PortNumber);

		[DllImport(@"wldap32", EntryPoint="ldap_first_attributeA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe sbyte* ldap_first_attributeA(LDAP* ExternalHandle, LDAPMessage* Message, BerElement** OpaqueResults);

		[DllImport(@"wldap32", EntryPoint="LdapUnicodeToUTF8", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe int LdapUnicodeToUTF8(ushort* lpSrcStr, int cchSrc, sbyte* lpDestStr, int cchDest);

		[DllImport(@"wldap32", EntryPoint="ldap_sasl_bindA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe int ldap_sasl_bindA(LDAP* ExternalHandle, sbyte* DistName, sbyte* AuthMechanism, BERVAL* cred, LDAPControlA** ServerCtrls, LDAPControlA** ClientCtrls, int* MessageNumber);

		[DllImport(@"wldap32", EntryPoint="ldap_deleteA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_deleteA(LDAP* ExternalHandle, sbyte* DistinguishedName);

		[DllImport(@"wldap32", EntryPoint="ldap_explode_dn", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe sbyte** ldap_explode_dn(sbyte* dn, uint notypes);

		[DllImport(@"wldap32", EntryPoint="ldap_initW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe LDAP* ldap_initW(ushort* HostName, uint PortNumber);

		[DllImport(@"wldap32", EntryPoint="ldap_value_free_len", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_value_free_len(sbyte** vals);

		[DllImport(@"wldap32", EntryPoint="cldap_openW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe LDAP* cldap_openW(ushort* HostName, uint PortNumber);

		[DllImport(@"wldap32", EntryPoint="ldap_first_attributeW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe ushort* ldap_first_attributeW(LDAP* ExternalHandle, LDAPMessage* Message, BerElement** OpaqueResults);

		[DllImport(@"wldap32", EntryPoint="ldap_get_values", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe sbyte** ldap_get_values(LDAP* ExternalHandle, LDAPMessage* Message, sbyte* Attribute);

		[DllImport(@"wldap32", EntryPoint="ldap_deleteW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_deleteW(LDAP* ExternalHandle, ushort* DistinguishedName);

		[DllImport(@"wldap32", EntryPoint="ber_alloc_t", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe BerElement* ber_alloc_t(int options);

		[DllImport(@"wldap32", EntryPoint="ldap_parse_reference", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_parse_reference(LDAP* ExternalHandle, LDAPMessage* ResultMessage, sbyte*** Referrals);

		[DllImport(@"wldap32", EntryPoint="ldap_extended_operation", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_extended_operation(LDAP* ExternalHandle, sbyte* Oid, BERVAL* Data, LDAPControlA** ServerControls, LDAPControlA** ClientControls, uint* MessageNumber);

		[DllImport(@"wldap32", EntryPoint="ldap_delete_ext_sA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_delete_ext_sA(LDAP* ExternalHandle, sbyte* DistinguishedName, LDAPControlA** ServerControls, LDAPControlA** ClientControls);

		[DllImport(@"wldap32", EntryPoint="ldap_escape_filter_element", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_escape_filter_element(sbyte* sourceFilterElement, uint sourceLength, sbyte* destFilterElement, uint destLength);

		[DllImport(@"wldap32", EntryPoint="ldap_memfreeA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe void ldap_memfreeA(sbyte* Block);

		[DllImport(@"wldap32", EntryPoint="ldap_modrdn2W", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_modrdn2W(LDAP* ExternalHandle, ushort* DistinguishedName, ushort* NewDistinguishedName, int DeleteOldRdn);

		[DllImport(@"wldap32", EntryPoint="ldap_sasl_bind_sA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe int ldap_sasl_bind_sA(LDAP* ExternalHandle, sbyte* DistName, sbyte* AuthMechanism, BERVAL* cred, LDAPControlA** ServerCtrls, LDAPControlA** ClientCtrls, BERVAL** ServerData);

		[DllImport(@"wldap32", EntryPoint="ber_next_element", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ber_next_element(BerElement* pBerElement, uint* pLen, sbyte* opaque);

		[DllImport(@"wldap32", EntryPoint="ldap_memfreeW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe void ldap_memfreeW(sbyte* Block);

		[DllImport(@"wldap32", EntryPoint="ldap_set_dbg_flags", CallingConvention=CallingConvention.Cdecl)]
		public static extern uint ldap_set_dbg_flags(uint NewFlags);

		[DllImport(@"wldap32", EntryPoint="ldap_modify_sA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_modify_sA(LDAP* ExternalHandle, sbyte* DistinguishedName, LDAPModA** AttributeList);

		[DllImport(@"wldap32", EntryPoint="ber_skip_tag", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ber_skip_tag(BerElement* pBerElement, uint* pLen);

		[DllImport(@"wldap32", EntryPoint="ldap_sasl_bind_sW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe int ldap_sasl_bind_sW(LDAP* ExternalHandle, ushort* DistName, ushort* AuthMechanism, BERVAL* cred, LDAPControlW** ServerCtrls, LDAPControlW** ClientCtrls, BERVAL** ServerData);

		[DllImport(@"wldap32", EntryPoint="ldap_search_stA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_search_stA(LDAP* ExternalHandle, sbyte* DistinguishedName, uint ScopeOfSearch, sbyte* SearchFilter, sbyte** AttributeList, uint AttributesOnly, LDAP_TIMEVAL* TimeOut, LDAPMessage** Results);

		[DllImport(@"wldap32", EntryPoint="ldap_simple_bind", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_simple_bind(LDAP* ExternalHandle, sbyte* DistName, sbyte* PassWord);

		[DllImport(@"wldap32", EntryPoint="ldap_create_page_controlA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_create_page_controlA(LDAP* ExternalHandle, uint PageSize, BERVAL* Cookie, byte IsCritical, LDAPControlA** Control);

		[DllImport(@"wldap32", EntryPoint="ldap_simple_bindW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_simple_bindW(LDAP* ExternalHandle, ushort* DistName, ushort* PassWord);

		[DllImport(@"wldap32", EntryPoint="ldap_parse_referenceW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_parse_referenceW(LDAP* ExternalHandle, LDAPMessage* ResultMessage, ushort*** Referrals);

		[DllImport(@"wldap32", EntryPoint="ldap_searchW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_searchW(LDAP* ExternalHandle, ushort* DistinguishedName, uint ScopeOfSearch, ushort* SearchFilter, ushort** AttributeList, uint AttributesOnly);

		[DllImport(@"wldap32", EntryPoint="ldap_parse_page_controlW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_parse_page_controlW(LDAP* ExternalHandle, LDAPControlW** ServerControls, uint* TotalCount, BERVAL** Cookie);

		[DllImport(@"wldap32", EntryPoint="ldap_unbind", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_unbind(LDAP* ExternalHandle);

		[DllImport(@"wldap32", EntryPoint="ldap_parse_resultW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_parse_resultW(LDAP* ExternalHandle, LDAPMessage* ResultMessage, uint* ReturnCode, ushort** MatchedDNs, ushort** ErrorMessage, ushort*** Referrals, LDAPControlW*** ServerControls, byte Freeit);

		[DllImport(@"wldap32", EntryPoint="ldap_modify_sW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_modify_sW(LDAP* ExternalHandle, ushort* DistinguishedName, LDAPModW** AttributeList);

		[DllImport(@"wldap32", EntryPoint="ldap_simple_bindA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_simple_bindA(LDAP* ExternalHandle, sbyte* DistName, sbyte* PassWord);

		[DllImport(@"wldap32", EntryPoint="ber_scanf", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ber_scanf(BerElement* pBerElement, sbyte* fmt, uint uLong);

		[DllImport(@"wldap32", EntryPoint="ldap_create_page_controlW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_create_page_controlW(LDAP* ExternalHandle, uint PageSize, BERVAL* Cookie, byte IsCritical, LDAPControlW** Control);

		[DllImport(@"wldap32", EntryPoint="ldap_err2string", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe sbyte* ldap_err2string(uint err);

		[DllImport(@"wldap32", EntryPoint="ldap_next_attributeW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe ushort* ldap_next_attributeW(LDAP* ExternalHandle, LDAPMessage* Message, BerElement* OpaqueResults);

		[DllImport(@"wldap32", EntryPoint="ldap_searchA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_searchA(LDAP* ExternalHandle, sbyte* DistinguishedName, uint ScopeOfSearch, sbyte* SearchFilter, sbyte** AttributeList, uint AttributesOnly);

		[DllImport(@"wldap32", EntryPoint="ber_free", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe void ber_free(BerElement* pBerElement, int fbuf);

		[DllImport(@"wldap32", EntryPoint="ldap_search_init_page", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe LDAPSearch* ldap_search_init_page(LDAP* ExternalHandle, sbyte* DistinguishedName, uint ScopeOfSearch, sbyte* SearchFilter, sbyte** AttributeList, uint AttributesOnly, LDAPControlA** ServerControls, LDAPControlA** ClientControls, uint PageTimeLimit, uint TotalSizeLimit, LDAPSortKeyA** SortKeys);

		[DllImport(@"wldap32", EntryPoint="ldap_parse_referenceA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_parse_referenceA(LDAP* ExternalHandle, LDAPMessage* ResultMessage, sbyte*** Referrals);

		[DllImport(@"wldap32", EntryPoint="ldap_parse_page_controlA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_parse_page_controlA(LDAP* ExternalHandle, LDAPControlA** ServerControls, uint* TotalCount, BERVAL** Cookie);

		[DllImport(@"wldap32", EntryPoint="ldap_bind_s", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_bind_s(LDAP* ExternalHandle, sbyte* DistName, sbyte* Cred, uint Method);

		[DllImport(@"wldap32", EntryPoint="ldap_next_attributeA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe sbyte* ldap_next_attributeA(LDAP* ExternalHandle, LDAPMessage* Message, BerElement* OpaqueResults);

		[DllImport(@"wldap32", EntryPoint="ldap_parse_resultA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_parse_resultA(LDAP* ExternalHandle, LDAPMessage* ResultMessage, uint* ReturnCode, sbyte** MatchedDNs, sbyte** ErrorMessage, sbyte*** Referrals, LDAPControlA*** ServerControls, byte Freeit);

		[DllImport(@"wldap32", EntryPoint="ldap_search_extW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_search_extW(LDAP* ExternalHandle, ushort* DistinguishedName, uint ScopeOfSearch, ushort* SearchFilter, ushort** AttributeList, uint AttributesOnly, LDAPControlW** ServerControls, LDAPControlW** ClientControls, uint TimeLimit, uint SizeLimit, uint* MessageNumber);

		[DllImport(@"wldap32", EntryPoint="ldap_check_filterA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_check_filterA(LDAP* ld, sbyte* SearchFilter);

		[DllImport(@"wldap32", EntryPoint="ldap_get_valuesA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe sbyte** ldap_get_valuesA(LDAP* ExternalHandle, LDAPMessage* Message, sbyte* Attribute);

		[DllImport(@"wldap32", EntryPoint="ldap_get_dnW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe ushort* ldap_get_dnW(LDAP* ExternalHandle, LDAPMessage* LdapMsg);

		[DllImport(@"wldap32", EntryPoint="ldap_simple_bind_s", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_simple_bind_s(LDAP* ExternalHandle, sbyte* DistName, sbyte* PassWord);

		[DllImport(@"wldap32", EntryPoint="ldap_start_tls_sW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_start_tls_sW(LDAP* ExternalHandle, uint* ServerReturnValue, LDAPMessage** result, LDAPControlW** ServerControls, LDAPControlW** ClientControls);

		[DllImport(@"wldap32", EntryPoint="ldap_create_sort_controlA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_create_sort_controlA(LDAP* ExternalHandle, LDAPSortKeyA** SortKeys, byte IsCritical, LDAPControlA** Control);

		[DllImport(@"wldap32", EntryPoint="ldap_next_reference", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe LDAPMessage* ldap_next_reference(LDAP* ExternalHandle, LDAPMessage* entry);

		[DllImport(@"wldap32", EntryPoint="ldap_modrdn_sW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_modrdn_sW(LDAP* ExternalHandle, ushort* DistinguishedName, ushort* NewDistinguishedName);

		[DllImport(@"wldap32", EntryPoint="ldap_check_filterW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_check_filterW(LDAP* ExternalHandle, ushort* SearchFilter);

		[DllImport(@"wldap32", EntryPoint="ldap_get_valuesW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe ushort** ldap_get_valuesW(LDAP* ExternalHandle, LDAPMessage* Message, ushort* Attribute);

		[DllImport(@"wldap32", EntryPoint="ldap_set_option", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_set_option(LDAP* ExternalHandle, int option, void* invalue);

		[DllImport(@"wldap32", EntryPoint="ldap_create_sort_controlW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_create_sort_controlW(LDAP* ExternalHandle, LDAPSortKeyW** SortKeys, byte IsCritical, LDAPControlW** Control);

		[DllImport(@"wldap32", EntryPoint="ldap_search_st", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_search_st(LDAP* ExternalHandle, sbyte* DistinguishedName, uint ScopeOfSearch, sbyte* SearchFilter, sbyte** AttributeList, uint AttributesOnly, LDAP_TIMEVAL* TimeOut, LDAPMessage** Results);

		[DllImport(@"wldap32", EntryPoint="ldap_get_dnA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe sbyte* ldap_get_dnA(LDAP* ExternalHandle, LDAPMessage* LdapMsg);

		[DllImport(@"wldap32", EntryPoint="ldap_add_ext_sA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_add_ext_sA(LDAP* ExternalHandle, sbyte* DistinguishedName, LDAPModA** AttributeList, LDAPControlA** ServerControls, LDAPControlA** ClientControls);

		[DllImport(@"wldap32", EntryPoint="ldap_rename_ext", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_rename_ext(LDAP* ExternalHandle, sbyte* DistinguishedName, sbyte* NewRDN, sbyte* NewParent, int DeleteOldRdn, LDAPControlA** ServerControls, LDAPControlA** ClientControls, uint* MessageNumber);

		[DllImport(@"wldap32", EntryPoint="ldap_add_ext_s", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_add_ext_s(LDAP* ExternalHandle, sbyte* DistinguishedName, LDAPModA** AttributeList, LDAPControlA** ServerControls, LDAPControlA** ClientControls);

		[DllImport(@"wldap32", EntryPoint="ldap_set_dbg_routine", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe void ldap_set_dbg_routine(/*fn ptr->delegate: DBGPRINT*/ void* DebugPrintRoutine);

		[DllImport(@"wldap32", EntryPoint="ldap_add_s", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_add_s(LDAP* ExternalHandle, sbyte* DistinguishedName, LDAPModA** AttributeList);

		[DllImport(@"wldap32", EntryPoint="ldap_next_entry", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe LDAPMessage* ldap_next_entry(LDAP* ExternalHandle, LDAPMessage* entry);

		[DllImport(@"wldap32", EntryPoint="ldap_init", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe LDAP* ldap_init(sbyte* HostName, uint PortNumber);

		[DllImport(@"wldap32", EntryPoint="ldap_modrdn2A", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_modrdn2A(LDAP* ExternalHandle, sbyte* DistinguishedName, sbyte* NewDistinguishedName, int DeleteOldRdn);

		[DllImport(@"wldap32", EntryPoint="ldap_count_values_len", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_count_values_len(sbyte** vals);

		[DllImport(@"wldap32", EntryPoint="ldap_create_vlv_controlW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe int ldap_create_vlv_controlW(LDAP* ExternalHandle, LDAPVLVInfo* VlvInfo, byte IsCritical, LDAPControlW** Control);

		[DllImport(@"wldap32", EntryPoint="LdapUTF8ToUnicode", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe int LdapUTF8ToUnicode(sbyte* lpSrcStr, int cchSrc, ushort* lpDestStr, int cchDest);

		[DllImport(@"wldap32", EntryPoint="ldap_result", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_result(LDAP* ExternalHandle, uint msgid, uint AllOfMessage, LDAP_TIMEVAL* TimeOut, LDAPMessage** res);

		[DllImport(@"wldap32", EntryPoint="ldap_modify_ext_sW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_modify_ext_sW(LDAP* ExternalHandle, ushort* DistinguishedName, LDAPModW** AttributeList, LDAPControlW** ServerControls, LDAPControlW** ClientControls);

		[DllImport(@"wldap32", EntryPoint="ldap_delete_extW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_delete_extW(LDAP* ExternalHandle, ushort* dn, LDAPControlW** ServerControls, LDAPControlW** ClientControls, uint* MessageNumber);

		[DllImport(@"wldap32", EntryPoint="ldap_value_freeW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_value_freeW(sbyte** vals);

		[DllImport(@"wldap32", EntryPoint="ldap_modrdnA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_modrdnA(LDAP* ExternalHandle, sbyte* DistinguishedName, sbyte* NewDistinguishedName);

		[DllImport(@"wldap32", EntryPoint="ldap_create_vlv_controlA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe int ldap_create_vlv_controlA(LDAP* ExternalHandle, LDAPVLVInfo* VlvInfo, byte IsCritical, LDAPControlA** Control);

		[DllImport(@"wldap32", EntryPoint="ldap_modifyA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_modifyA(LDAP* ExternalHandle, sbyte* DistinguishedName, LDAPModA** AttributeList);

		[DllImport(@"wldap32", EntryPoint="ldap_next_attribute", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe sbyte* ldap_next_attribute(LDAP* ExternalHandle, LDAPMessage* Message, BerElement* OpaqueResults);

		[DllImport(@"wldap32", EntryPoint="ldap_compare_s", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_compare_s(LDAP* ExternalHandle, sbyte* DistinguishedName, sbyte* Attribute, sbyte* Value);

		[DllImport(@"wldap32", EntryPoint="ldap_search_ext_s", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_search_ext_s(LDAP* ExternalHandle, sbyte* DistinguishedName, uint ScopeOfSearch, sbyte* SearchFilter, sbyte** AttributeList, uint AttributesOnly, LDAPControlA** ServerControls, LDAPControlA** ClientControls, LDAP_TIMEVAL* timeout, uint SizeLimit, LDAPMessage** Results);

		[DllImport(@"wldap32", EntryPoint="ldap_delete_extA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_delete_extA(LDAP* ExternalHandle, sbyte* DistinguishedName, LDAPControlA** ServerControls, LDAPControlA** ClientControls, uint* MessageNumber);

		[DllImport(@"wldap32", EntryPoint="ldap_modify_ext_sA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_modify_ext_sA(LDAP* ExternalHandle, sbyte* DistinguishedName, LDAPModA** AttributeList, LDAPControlA** ServerControls, LDAPControlA** ClientControls);

		[DllImport(@"wldap32", EntryPoint="ldap_cleanup", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_cleanup(void* hInstance);

		[DllImport(@"wldap32", EntryPoint="ldap_value_freeA", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_value_freeA(sbyte** vals);

		[DllImport(@"wldap32", EntryPoint="ldap_modrdnW", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_modrdnW(LDAP* ExternalHandle, ushort* DistinguishedName, ushort* NewDistinguishedName);

		[DllImport(@"wldap32", EntryPoint="ldap_modify_ext", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_modify_ext(LDAP* ExternalHandle, sbyte* DistinguishedName, LDAPModA** AttributeList, LDAPControlA** ServerControls, LDAPControlA** ClientControls, uint* MessageNumber);

		[DllImport(@"wldap32", EntryPoint="ldap_compare_ext_s", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_compare_ext_s(LDAP* ExternalHandle, sbyte* DistinguishedName, sbyte* Attr, sbyte* Value, BERVAL* Data, LDAPControlA** ServerControls, LDAPControlA** ClientControls);

		[DllImport(@"wldap32", EntryPoint="ldap_stop_tls_s", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe byte ldap_stop_tls_s(LDAP* ExternalHandle);

		[DllImport(@"wldap32", EntryPoint="ldap_modify", CallingConvention=CallingConvention.Cdecl)]
		public static extern unsafe uint ldap_modify(LDAP* ExternalHandle, sbyte* DistinguishedName, LDAPModA** AttributeList);

	}

	#region structs (14)

	[StructLayout(LayoutKind.Explicit, Size=16)]
	public struct LDAPControlW
	{
		[FieldOffset(0)]
		public unsafe ushort* ldctl_oid;

		[FieldOffset(4)]
		public BERVAL ldctl_value;

		[FieldOffset(12)]
		public byte ldctl_iscritical;
	}

	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct BERVAL
	{
		[FieldOffset(0)]
		public uint bv_len;

		[FieldOffset(4)]
		public unsafe sbyte* bv_val;
	}

	[StructLayout(LayoutKind.Explicit, Size=0)]
	public struct LDAPSearch
	{	}

	[StructLayout(LayoutKind.Explicit, Size=12)]
	public struct LDAPSortKeyA
	{
		[FieldOffset(0)]
		public unsafe sbyte* sk_attrtype;

		[FieldOffset(4)]
		public unsafe sbyte* sk_matchruleoid;

		[FieldOffset(8)]
		public byte sk_reverseorder;
	}

	[StructLayout(LayoutKind.Explicit, Size=4)]
	public struct BerElement
	{
		[FieldOffset(0)]
		public unsafe sbyte* opaque;
	}

	[StructLayout(LayoutKind.Explicit, Size=44)]
	public struct LDAPMessage
	{
		[FieldOffset(0)]
		public uint lm_msgid;

		[FieldOffset(4)]
		public uint lm_msgtype;

		[FieldOffset(8)]
		public unsafe void* lm_ber;

		[FieldOffset(12)]
		public unsafe LDAPMessage* lm_chain;

		[FieldOffset(16)]
		public unsafe LDAPMessage* lm_next;

		[FieldOffset(20)]
		public uint lm_time;

		[FieldOffset(24)]
		public unsafe LDAP* Connection;

		[FieldOffset(28)]
		public unsafe void* Request;

		[FieldOffset(32)]
		public uint lm_returncode;

		[FieldOffset(36)]
		public ushort lm_referral;

		[FieldOffset(38)]
		public byte lm_chased;

		[FieldOffset(39)]
		public byte lm_eom;

		[FieldOffset(40)]
		public byte ConnectionReferenced;
	}

	[StructLayout(LayoutKind.Explicit, Size=16)]
	public struct LDAPControlA
	{
		[FieldOffset(0)]
		public unsafe sbyte* ldctl_oid;

		[FieldOffset(4)]
		public BERVAL ldctl_value;

		[FieldOffset(12)]
		public byte ldctl_iscritical;
	}

	[StructLayout(LayoutKind.Explicit, Size=32)]
	public struct LDAPVLVInfo
	{
		[FieldOffset(0)]
		public int ldvlv_version;

		[FieldOffset(4)]
		public uint ldvlv_before_count;

		[FieldOffset(8)]
		public uint ldvlv_after_count;

		[FieldOffset(12)]
		public uint ldvlv_offset;

		[FieldOffset(16)]
		public uint ldvlv_count;

		[FieldOffset(20)]
		public unsafe BERVAL* ldvlv_attrvalue;

		[FieldOffset(24)]
		public unsafe BERVAL* ldvlv_context;

		[FieldOffset(28)]
		public unsafe void* ldvlv_extradata;
	}

	[StructLayout(LayoutKind.Explicit, Size=12)]
	public struct LDAPModW
	{
		[FieldOffset(0)]
		public uint mod_op;

		[FieldOffset(4)]
		public unsafe ushort* mod_type;

		[FieldOffset(8)]
		public nested_mod_vals mod_vals;
		[StructLayout(LayoutKind.Explicit, Size=4)]
		public struct nested_mod_vals
		{
			[FieldOffset(0)]
			public unsafe ushort** modv_strvals;

			[FieldOffset(0)]
			public unsafe BERVAL** modv_bvals;
		}
	}

	[StructLayout(LayoutKind.Explicit, Size=12)]
	public struct LDAPSortKeyW
	{
		[FieldOffset(0)]
		public unsafe ushort* sk_attrtype;

		[FieldOffset(4)]
		public unsafe ushort* sk_matchruleoid;

		[FieldOffset(8)]
		public byte sk_reverseorder;
	}

	[StructLayout(LayoutKind.Explicit, Size=12)]
	public struct LDAP_VERSION_INFO
	{
		[FieldOffset(0)]
		public uint lv_size;

		[FieldOffset(4)]
		public uint lv_major;

		[FieldOffset(8)]
		public uint lv_minor;
	}

	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct LDAP_TIMEVAL
	{
		[FieldOffset(0)]
		public int tv_sec;

		[FieldOffset(4)]
		public int tv_usec;
	}

	[StructLayout(LayoutKind.Explicit, Size=160)]
	public struct LDAP
	{
		[FieldOffset(0)]
		public nested_ld_sb ld_sb;
		[StructLayout(LayoutKind.Explicit, Size=76)]
		public struct nested_ld_sb
		{
			[FieldOffset(0)]
			public uint sb_sd;

			//Fixed-length Array "Reserved1[41]". Members can be
			//accessed with (&my_nested_ld_sb.Reserved1_41)[index]
			[FieldOffset(4)]
			public byte Reserved1_41;

			[FieldOffset(48)]
			public uint sb_naddr;

			//Fixed-length Array "Reserved2[24]". Members can be
			//accessed with (&my_nested_ld_sb.Reserved2_24)[index]
			[FieldOffset(52)]
			public byte Reserved2_24;
		}

		[FieldOffset(76)]
		public unsafe sbyte* ld_host;

		[FieldOffset(80)]
		public uint ld_version;

		[FieldOffset(84)]
		public byte ld_lberoptions;

		[FieldOffset(88)]
		public uint ld_deref;

		[FieldOffset(92)]
		public uint ld_timelimit;

		[FieldOffset(96)]
		public uint ld_sizelimit;

		[FieldOffset(100)]
		public uint ld_errno;

		[FieldOffset(104)]
		public unsafe sbyte* ld_matched;

		[FieldOffset(108)]
		public unsafe sbyte* ld_error;

		[FieldOffset(112)]
		public uint ld_msgid;

		//Fixed-length Array "Reserved3[25]". Members can be
		//accessed with (&my_LDAP.Reserved3_25)[index]
		[FieldOffset(116)]
		public byte Reserved3_25;

		[FieldOffset(144)]
		public uint ld_cldaptries;

		[FieldOffset(148)]
		public uint ld_cldaptimeout;

		[FieldOffset(152)]
		public uint ld_refhoplimit;

		[FieldOffset(156)]
		public uint ld_options;
	}

	[StructLayout(LayoutKind.Explicit, Size=12)]
	public struct LDAPModA
	{
		[FieldOffset(0)]
		public uint mod_op;

		[FieldOffset(4)]
		public unsafe sbyte* mod_type;

		[FieldOffset(8)]
		public nested_mod_vals mod_vals;
		[StructLayout(LayoutKind.Explicit, Size=4)]
		public struct nested_mod_vals
		{
			[FieldOffset(0)]
			public unsafe sbyte** modv_strvals;

			[FieldOffset(0)]
			public unsafe BERVAL** modv_bvals;
		}
	}
	#endregion

	#region delegates (1)
	//note: Delegates marshalled from Function Ptrs pointing to 
	//	unmanaged code cannot be called from C# in version 7.0
	//Generated delegate "DBGPRINT" contains argument withno_type, skipping

	#region delegate helper functions
	class Helpers
	{
		//These helper functions are generated as a workaround to allow
		//	the conversion of a Delegate to void *.  This allows the user
		//	to avoid dealing with the Marshalling of delegates when
		//	allowing unmanaged code to call a C# function.
	}
	#endregion
	#endregion
}

//comletion time: 2:40:38 PM
