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
using LDAP32;

namespace LDAP
{
	
	unsafe class SimpleBind
	{
		private static uint LDAP_PORT = 389;
		[STAThread]
		static void Main(string[] args)
		{

			//Using ASCII :(
			LDAP32.LDAP* pLdap = null;
			sbyte* pServer = (sbyte*)Marshal.StringToCoTaskMemAnsi("dsaddom.nttest.microsoft.com");
			sbyte* pName = (sbyte*)Marshal.StringToCoTaskMemAnsi("CN=Greg MacBeth,CN=Users,DC=dsaddom,DC=nttest,DC=MICROSOFT,DC=COM");
			sbyte* pPassword = (sbyte*)Marshal.StringToCoTaskMemAnsi("gregmcb");
			uint Result = 0;

            pLdap = Wldap32.ldap_init(pServer, LDAP_PORT);
			if(pLdap != null)
			{
				Result = Wldap32.ldap_simple_bind_s(pLdap, pName, pPassword);
			}

			Wldap32.ldap_unbind(pLdap);

			//Using UNICODE :)
			pLdap = null;
			ushort* pUServer = (ushort*)Marshal.StringToCoTaskMemUni("dsaddom.nttest.microsoft.com");
			ushort* pUName = (ushort*)Marshal.StringToCoTaskMemUni("CN=Greg MacBeth,CN=Users,DC=dsaddom,DC=nttest,DC=MICROSOFT,DC=COM");
			ushort* pUPassword = (ushort*)Marshal.StringToCoTaskMemUni("gregmcb");

			pLdap = Wldap32.ldap_initW(pUServer, LDAP_PORT);
			if(pLdap != null)
			{
				Result = Wldap32.ldap_simple_bind_sW(pLdap, pUName, pUPassword);
			}
			
			Wldap32.ldap_unbind(pLdap);

		}
	}
}
