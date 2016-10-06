using System;
using System.DirectoryServices;
using ActiveDs;

namespace LsaLookupNames2Test
{
	
	class Class1
	{
		
		[STAThread]
		static void Main(string[] args)
		{
			string Path = "LDAP://dsaddom.nttest.microsoft.com:636/CN=Welby,OU=gregmcb,DC=dsaddom,DC=nttest,DC=microsoft,DC=com";
			string User = "dsaddom\\gregmcb";
			string Password = "gregmcb";
			DirectoryEntry Entry = new DirectoryEntry(Path, User, Password);
			//Force NTLM
			//Entry.AuthenticationType = AuthenticationTypes.Secure;

			//IADsUser IUsr = (IADsUser) Entry.NativeObject;
			//IUsr.ChangePassword("Yes", "welby");

			Entry.Close();
		}
	}
}
