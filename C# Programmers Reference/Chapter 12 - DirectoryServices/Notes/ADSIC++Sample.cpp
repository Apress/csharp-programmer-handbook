//Simple ADSI Starter Code - Required Platform SDK
//Author: Gregory S. MacBeth
//Contact: gregmcb@microsoft.com

/*
Usage Instructions:
	1. ComUtil objects
		A. _bstr_t - Wraps BSTR objects providing memory management, conversions to Unicode or ANSI
		B. _variant_t - Wraps VARIANT types
		C. _com_error - Error thrown by the above two classes when they fail
	2. AD Path Usage
		A. "providername://FQDN/objectName"
			"LDAP://192.168.1.1/CN=Gregory MacBeth,CN=Users,DC=Test,DC=Com"
			"LDAP://red-dc-01.redmond.microsoft.com/CN=Gregory MacBeth,CN=Users,DC=Test, DC=Com"
			"LDAP://rootDSE" <-Serverless binding
			1. Serverless Binding - Allows for the use of DNS to find a DS server in the same site and domain as user running the program
			2. Valid Providers
				a. LDAP - Port 389/SSL 636
				b. GC - Port 3268/SSL 3269
				c. WinNT - NT 4 Domains
				d. NDS - Novell NDS servers
				e. NWCompat - NetWare 3.x servers
		B. Using a GUID - "ProviderName://FQDN/<GUID=XXXXXX>"
			1. ADsEncodeBinaryData - will produce the correct GUID needed above
*/

//Adds the appropriate lib files required in link
//Search first in the working directory then the LIB path
#pragma comment( lib, "activeds" )
#pragma comment( lib, "adsiid" )
#pragma comment( lib, "comsupp" )

//Adds the appropriate include dir
#include <windows.h>
#include <activeds.h>
#include <comutil.h>
#include <iostream>

using namespace std;


//method declerations
void HandleVariantArray(_variant_t var);
void UseIADs_GetASingleAttribute(IADs* pIADs);
void UseIADs_GetAMultivaluedAttribute(IADs* pIADs);
void UseIADs_GetExToRetrieveASingleValueAttribute(IADs* pIADs);
void UseIADs_GetExToRetrieveAMultiValuedAttribute(IADs* pIADs);
void UseIADs_GetInfoExToRetrieveSelectedAttribute();
void UseIADs_PutToChangeASingleValuedAttribute();
void UseIADs_PutToChangeAMultiValuedAttribute();
void UseIADs_PutExToAppendAMultiValuedProperty();
void UseIADs_PutExToRemoveValuesFromAMultiValuedAttribute();
void UseIADs_PutExToClearAMultiValuedAttribute();
void DisplayAttributes(_variant_t var);
void UseIADsPropertyList_ToDisplayAllAttributesOfObject(IADs* pIADs);
void IDirectoryObject_ToRetrieveAttributes(IADs* pIADs);
void IADsContainer_EnumerationInAContainerSample(IADs* pIADs);
void IADsContainer_EnumerationWithFilterAndHints(IADs* pIADs);
void IADsContainer_ToCreateANewUser(IADs* pIADs);
void IADsContainer_DeleteAUser(IADs* pIADs);
void IADsContainer_MoveAUser(IADs* pIADs);
void IAdsDeleteOps_DeleteAnOU(IADs* pIADs);

int main(int argc, char* argv[])
{
	HRESULT hr = CoInitialize(NULL);

	if(SUCCEEDED(hr))
	{
		IADs* pIADs = NULL;

		//Basic ADSI access
		hr = ADsGetObject(
							L"LDAP://dsaddom.nttest.microsoft.com/rootDSE",
							IID_IADs,
							(void**)&pIADs);
		

		/*Used when you need to specify username, password, & authentication options
		hr = ADsOpenObject(
			L"LDAP://test.testdom.com/rootDSE",
			L"Redmond\MyUser",
			L"MyPassword",
			ADS_SECURE_AUTHENTICATION,
			IID_IADs,
			(void **)&pIADs);
		*/

		if(SUCCEEDED(hr))
		{
			//READING ATTRIBUTE METHODS
			//All these result in all attributes being retrived and placed into the property cache
			//Use IADs->Get() to retrieve an attributes of an object
			//UseIADs_GetASingleAttribute(pIADs);
			
			//Use IADs>Get() to retrieve a multivalued attribute of an object
			//UseIADs_GetAMultivaluedAttribute(pIADs);
			
			//Use IADs->GetEx to retrieve a Single Valued Attribute
			//UseIADs_GetExToRetrieveASingleValueAttribute(pIADs);

			//Use IADs->GetEx to retrieve a Multi-Valued attribute
			//UseIADs_GetExToRetrieveAMultiValuedAttribute(pIADs);

			//IADs->GetInfoEx can be used to retrieve selected attributes
			//UseIADs_GetInfoExToRetrieveSelectedAttribute();

			//Sample code showing how to Set a single Valued property
			//UseIADs_PutToChangeASingleValuedAttribute();

			//Sample code showing how to set a multi-valued property
			//UseIADs_PutToChangeAMultiValuedAttribute();

			//Append a multi-valued attribute
			//UseIADs_PutExToAppendAMultiValuedProperty();

			//Deletes a member of a multi-valued property
			//UseIADs_PutExToRemoveValuesFromAMultiValuedAttribute();

			//cLEAR A MULTI-VALUED PROPERTY
			//UseIADs_PutExToClearAMultiValuedAttribute();

			//Show all Attributes and there values of an object
			//UseIADsPropertyList_ToDisplayAllAttributesOfObject(pIADs);

			//Use IDirectoryObject to scan attributes and values on an object
			//IDirectoryObject_ToRetrieveAttributes(pIADs);

			//Use IADsContainer to enumerate through a container
			//IADsContainer_EnumerationInAContainerSample(pIADs);

			//Using IADsContainer to set filters and hints
			//IADsContainer_EnumerationWithFilterAndHints(pIADs);

			//Create A User using IADsContainer
			//IADsContainer_ToCreateANewUser(pIADs);

			//Deletes a User using IADsContainer->Delete()
			//IADsContainer_DeleteAUser(pIADs);

			//Moves a User using IADsContainer
			//IADsContainer_MoveAUser(pIADs);

			//Delete an OU
			//IAdsDeleteOps_DeleteAnOU(pIADs);

			pIADs->Release();
		}

		CoUninitialize();
	}


	return 0;
}

void HandleVariantArray(_variant_t var)
{
	HRESULT hr = NULL;
	SAFEARRAY* array;
	long lowerBound = 0;
	long upperBound = 0;
	_variant_t result;

	if(V_ISARRAY(&var))
	{
		array = V_ARRAY(&var);
		if(array != NULL)
		{
			//Get the range of an array
			SafeArrayGetLBound(array, 1, &lowerBound);
			SafeArrayGetUBound(array, 1, &upperBound);
			
			//Read through each element
			for(long index = lowerBound; index <= upperBound; index++)
			{
				//Get each item
				hr = SafeArrayGetElement(array, &index, &result);
				if(SUCCEEDED(hr))
				{
					//print the result
					cout << (const char*)_bstr_t(result) << endl;
				}

			}
		}
	}

}

//This method shows how to retrieve an attribute for a specific object
//pIADs->Get returns a VARIANT
void UseIADs_GetASingleAttribute(IADs* pIADs)
{
	_variant_t varDefaultNamingContext;
	HRESULT hr = NULL;
	

	hr = pIADs->Get(L"defaultNamingContext", &varDefaultNamingContext);
	if(SUCCEEDED(hr))
	{
		_bstr_t strDefaultNamingContext = varDefaultNamingContext;
		cout << (const char*)strDefaultNamingContext << endl;

	}
	return;
}

//This method shows how to retrieve MULTI-VALUED attribute for a specific object
//pIADs->Get returns a VARIANT
void UseIADs_GetAMultivaluedAttribute(IADs* pIADs)
{
	_variant_t varNamingContext;
	HRESULT hr = NULL;

	hr = pIADs->Get(L"namingContexts", &varNamingContext);
	//make sure we succeeded and got an array back
	if(SUCCEEDED(hr) && V_ISARRAY(&varNamingContext))
	{
		HandleVariantArray(varNamingContext);
	}
	return;
}

void UseIADs_GetExToRetrieveASingleValueAttribute(IADs* pIADs)
{
	HRESULT hr= NULL;
	_variant_t result;
	
	hr = pIADs->GetEx(L"defaultNamingContext", &result);
	if(SUCCEEDED(hr) && V_ISARRAY(&result))
	{
		HandleVariantArray(&result);
	}
	
	return;
}

void UseIADs_GetExToRetrieveAMultiValuedAttribute(IADs* pIADs)
{
	HRESULT hr= NULL;
	_variant_t result;
	
	hr = pIADs->GetEx(L"NamingContexts", &result);
	if(SUCCEEDED(hr) && V_ISARRAY(&result))
	{
		HandleVariantArray(&result);
	}
	
	return;
}

void UseIADs_GetInfoExToRetrieveSelectedAttribute()
{
	HRESULT hr = NULL;
	IADs* pIADs = NULL;

	hr = ADsOpenObject(
						L"LDAP://dsaddom.nttest.microsoft.com/CN=Greg MacBeth,CN=Users,DC=dsaddom,DC=nttest,DC=MICROSOFT,DC=COM",
						L"dsaddom\\gregmcb",
						L"gregmcb",
						ADS_SECURE_AUTHENTICATION,
						IID_IADs,
						(void **)&pIADs);

	if(SUCCEEDED(hr))
	{
		wchar_t* attributeNames[] = {L"displayName", L"sAMAccountName"};
		_variant_t var;
		HRESULT hr = NULL;
		IADsPropertyList* piPropertyList = NULL;
		long propCount = 0;

		hr = ADsBuildVarArrayStr(attributeNames, 2, &var);
		if(SUCCEEDED(hr))
		{
			//Fill the property cache with only the properties requested above
			hr= pIADs->GetInfoEx(var, 0);
			if(SUCCEEDED(hr))
			{
				//Dump the property cache
				hr = pIADs->QueryInterface(IID_IADsPropertyList, (void **) &piPropertyList);
				if(SUCCEEDED(hr))
				{
					//Get the property Count in the Cache
					piPropertyList->get_PropertyCount(&propCount);

					//Read through the property cache
					for(int prop = 0; prop < propCount; prop++)
					{
						_variant_t varProp;
						piPropertyList->Next(&varProp);

						IADsPropertyEntry* piEntry = NULL;
						//Get the property
						hr = ((IDispatch*)varProp)->QueryInterface(IID_IADsPropertyEntry, (void **)&piEntry);
						if(SUCCEEDED(hr))
						{
							BSTR attributeName;
							piEntry->get_Name(&attributeName);

							cout << (const char*)_bstr_t(attributeName) << endl;
							piEntry->Release();
						}
						
					}
					piPropertyList->Release();
				}
				//Read and print results
				_variant_t varName;
				hr = pIADs->Get(L"displayName", &varName);
				if(SUCCEEDED(hr))
				{
					cout << (const char*)_bstr_t(varName) << endl;
				}
			}
		}
		pIADs->Release();

	}
	return;
}

void UseIADs_PutToChangeASingleValuedAttribute()
{
	HRESULT hr = NULL;
	IADs* pIADs = NULL;
	_variant_t var;


	hr = ADsOpenObject(
						L"LDAP://dsaddom.nttest.microsoft.com/CN=Greg MacBeth,CN=Users,DC=dsaddom,DC=nttest,DC=MICROSOFT,DC=COM",
						L"dsaddom\\gregmcb",
						L"gregmcb",
						ADS_SECURE_AUTHENTICATION,
						IID_IADs,
						(void **)&pIADs);
	if(SUCCEEDED(hr))
	{
		hr = pIADs->Get(L"givenName", &var);
		if(SUCCEEDED(hr))
		{
			hr = pIADs->Put(L"givenName", _variant_t("FirstName"));
			if(SUCCEEDED(hr))
			{
				pIADs->SetInfo();
			}
		}

		UseIADs_GetASingleAttribute(pIADs);
	}

	pIADs->Release();
	return;

}

void UseIADs_PutToChangeAMultiValuedAttribute()
{
	HRESULT hr = NULL;
	IADs* pIADs = NULL;
	_variant_t var;
	_variant_t result;
	wchar_t* attributeNames[] = {L"name1", L"name2"};


	hr = ADsOpenObject(
						L"LDAP://dsaddom.nttest.microsoft.com/CN=Greg MacBeth,CN=Users,DC=dsaddom,DC=nttest,DC=MICROSOFT,DC=COM",
						L"dsaddom\\gregmcb",
						L"gregmcb",
						ADS_SECURE_AUTHENTICATION,
						IID_IADs,
						(void **)&pIADs);
	if(SUCCEEDED(hr))
	{
		ADsBuildVarArrayStr(attributeNames, 2, &var);
		hr = pIADs->Put(L"accountNameHistory", var);
		if(SUCCEEDED(hr))
		{
			hr = pIADs->SetInfo();
		}

		hr = pIADs->Get(L"accountNameHistory", &result);
		//make sure we succeeded and got an array back
		if(SUCCEEDED(hr) && V_ISARRAY(&result))
		{
			HandleVariantArray(result);
		}
	}
	pIADs->Release();
}

void UseIADs_PutExToAppendAMultiValuedProperty()
{
	HRESULT hr = NULL;
	IADs* pIADs = NULL;
	_variant_t var;
	_variant_t result;
	wchar_t* attributeNames[] = {L"name3", L"name4"};


	hr = ADsOpenObject(
						L"LDAP://dsaddom.nttest.microsoft.com/CN=Greg MacBeth,CN=Users,DC=dsaddom,DC=nttest,DC=MICROSOFT,DC=COM",
						L"dsaddom\\gregmcb",
						L"gregmcb",
						ADS_SECURE_AUTHENTICATION,
						IID_IADs,
						(void **)&pIADs);
	if(SUCCEEDED(hr))
	{
		ADsBuildVarArrayStr(attributeNames, sizeof(attributeNames)/sizeof(attributeNames[0]), &var);
		hr = pIADs->PutEx(ADS_PROPERTY_APPEND, L"accountNameHistory", var);
		if(SUCCEEDED(hr))
		{
			hr = pIADs->SetInfo();
			hr = pIADs->Get(L"accountNameHistory", &result);
			//make sure we succeeded and got an array back
			if(SUCCEEDED(hr) && V_ISARRAY(&result))
			{
				HandleVariantArray(result);
			}

		}
	}

	pIADs->Release();

}

void UseIADs_PutExToRemoveValuesFromAMultiValuedAttribute()
{
	HRESULT hr = NULL;
	IADs* pIADs = NULL;
	_variant_t var;
	_variant_t result;
	wchar_t* attributeNames[] = {L"name3", L"name4"};


	hr = ADsOpenObject(
						L"LDAP://dsaddom.nttest.microsoft.com/CN=Greg MacBeth,CN=Users,DC=dsaddom,DC=nttest,DC=MICROSOFT,DC=COM",
						L"dsaddom\\gregmcb",
						L"gregmcb",
						ADS_SECURE_AUTHENTICATION,
						IID_IADs,
						(void **)&pIADs);
	if(SUCCEEDED(hr))
	{
		ADsBuildVarArrayStr(attributeNames, sizeof(attributeNames)/sizeof(attributeNames[0]), &var);
		hr = pIADs->PutEx(ADS_PROPERTY_DELETE, L"accountNameHistory", var);
		if(SUCCEEDED(hr))
		{
			hr = pIADs->SetInfo();
			hr = pIADs->Get(L"accountNameHistory", &result);
			//make sure we succeeded and got an array back
			if(SUCCEEDED(hr) && V_ISARRAY(&result))
			{
				HandleVariantArray(result);
			}

		}
	}

	pIADs->Release();

}

void UseIADs_PutExToClearAMultiValuedAttribute()
{
	HRESULT hr = NULL;
	IADs* pIADs = NULL;
	_variant_t var;
	_variant_t result;
	
	hr = ADsOpenObject(
						L"LDAP://dsaddom.nttest.microsoft.com/CN=Greg MacBeth,CN=Users,DC=dsaddom,DC=nttest,DC=MICROSOFT,DC=COM",
						L"dsaddom\\gregmcb",
						L"gregmcb",
						ADS_SECURE_AUTHENTICATION,
						IID_IADs,
						(void **)&pIADs);
	if(SUCCEEDED(hr))
	{
		
		hr = pIADs->PutEx(ADS_PROPERTY_CLEAR, L"accountNameHistory", var);
		if(SUCCEEDED(hr))
		{
			hr = pIADs->SetInfo();
			hr = pIADs->Get(L"accountNameHistory", &result);
			//make sure we succeeded and got an array back
			if(SUCCEEDED(hr) && V_ISARRAY(&result))
			{
				HandleVariantArray(result);
			}

		}
	}

	pIADs->Release();

}

void UseIADsPropertyList_ToDisplayAllAttributesOfObject(IADs* pIADs)
{
	IADsPropertyList* pList = NULL;
	HRESULT hr = NULL;
	_variant_t var;

	pIADs->GetInfo();

	hr = pIADs->QueryInterface(IID_IADsPropertyList, (void**)&pList);
	if(SUCCEEDED(hr))
	{
		while(pList->Next(&var) == S_OK)
		{
			DisplayAttributes(var);
		}
		pList->Release();
	}


}

void DisplayAttributes(_variant_t var)
{
	IADsPropertyEntry* piEntry = NULL;
	HRESULT hr = NULL;


	hr = ((IDispatch*)var)->QueryInterface(IID_IADsPropertyEntry, (void**)&piEntry);
	if(SUCCEEDED(hr))
	{
		BSTR AttributeName;
		_variant_t varValue;
		//Get The Attribute Name
		piEntry->get_Name(&AttributeName);
		cout << (const char*)_bstr_t(AttributeName) << ":";

		//Now Get the attribute Values
		piEntry->get_Values(&varValue);

		//Make SAFEARRAY from values
		SAFEARRAY* array = V_ARRAY(&varValue);
		if(array !=NULL)
		{
			long lowerBound = 0;
			long upperBound = 0;

			//Get the SAFEARRAY bounds
			SafeArrayGetLBound(array, 1, &lowerBound);
			SafeArrayGetUBound(array, 1, &upperBound);

			//Go through each entry in the array
			for(long index = lowerBound; index <= upperBound; index++)
			{
				_variant_t varVal;

				hr = SafeArrayGetElement(array, &index, &varVal);
				if(SUCCEEDED(hr))
				{
					IADsPropertyValue* piValue = NULL;
					hr = ((IDispatch*)varVal)->QueryInterface(IID_IADsPropertyValue, (void**)&piValue);
					if(SUCCEEDED(hr))
					{
						BSTR Value;
						hr = piValue->get_CaseIgnoreString(&Value);
						if(SUCCEEDED(hr))
						{
							cout << (const char*)_bstr_t(Value) << endl;
						}
						piValue->Release();
					}


				}
			}
		}

		piEntry->Release();
	}
}

void IDirectoryObject_ToRetrieveAttributes(IADs* pIADs)
{
	HRESULT hr = NULL;
	_variant_t var;
	IDirectoryObject* piDir = NULL;
	
	if(SUCCEEDED(hr))
	{
		hr = pIADs->Get(L"defaultNamingContext", &var);
		if(SUCCEEDED(hr))
		{
			hr = ADsGetObject(	_bstr_t("LDAP://dsaddom.nttest.microsoft.com/") + _bstr_t(var), 
								IID_IDirectoryObject,
								(void**)&piDir);
			if(SUCCEEDED(hr))
			{
				wchar_t* attributeNames[] = {L"name", L"masteredBy"};
				DWORD attributeReturned = 0;
				ADS_ATTR_INFO* ppAttributeInfo = NULL;

				hr = piDir->GetObjectAttributes(attributeNames, sizeof(attributeNames)/sizeof(attributeNames[0]), &ppAttributeInfo, &attributeReturned);
				if(SUCCEEDED(hr))
				{
					for(int indexAttribute = 0; indexAttribute < (int)attributeReturned; indexAttribute++)
					{
						for(int indexValue = 0; indexValue < (int)ppAttributeInfo[indexAttribute].dwNumValues; indexValue++)
						{
							wcout	<< ppAttributeInfo[indexAttribute].pszAttrName  
									<< indexValue << ":"
									<< ppAttributeInfo[indexAttribute].pADsValues[indexValue].CaseIgnoreString
									<< endl;
						}
					}
					FreeADsMem(ppAttributeInfo);
				}
				piDir->Release();
			}
		}
	}

}

void IADsContainer_EnumerationInAContainerSample(IADs* pIADs)
{
	HRESULT hr = NULL;
	_variant_t var;
	IADsContainer* piCon = NULL;
	
	if(SUCCEEDED(hr))
	{
		hr = pIADs->Get(L"defaultNamingContext", &var);
		if(SUCCEEDED(hr))
		{
			_bstr_t path = _bstr_t(L"LDAP://dsaddom.nttest.microsoft.com/") + L"CN=Users," + _bstr_t(var);
			hr = ADsOpenObject(	path, 
								L"dsaddom\\gregmcb",
								L"gregmcb",
								ADS_SECURE_AUTHENTICATION,
								IID_IADsContainer,
								(void**)&piCon);
			if(SUCCEEDED(hr))
			{
				IEnumVARIANT* piEnum = NULL;
				hr = ADsBuildEnumerator(piCon, &piEnum);
				if(SUCCEEDED(hr))
				{
					ULONG count = 0;
					_variant_t varEntry;

					while(ADsEnumerateNext(piEnum, 1, &varEntry, &count) == S_OK && count ==1)
					{
						IADs* piEntry = NULL;
						hr = ((IDispatch*)varEntry)->QueryInterface(IID_IADs, (void**)&piEntry);
						if(SUCCEEDED(hr))
						{
							BSTR Name;
							piEntry->get_Name(&Name);
							_bstr_t xxx = Name;
							cout << (const char*)xxx << endl;
							piEntry->Release();
						}
						((IDispatch*)varEntry)->Release();
					}
					piEnum->Release();
				}
				
				piCon->Release();
			}
		}
	}

}

void IADsContainer_EnumerationWithFilterAndHints(IADs* pIADs)
{
	HRESULT hr = NULL;
	_variant_t var;
	IADsContainer* piCon = NULL;
	
	if(SUCCEEDED(hr))
	{
		hr = pIADs->Get(L"defaultNamingContext", &var);
		if(SUCCEEDED(hr))
		{
			_bstr_t path = _bstr_t(L"LDAP://dsaddom.nttest.microsoft.com/") + L"CN=Users," + _bstr_t(var);
			hr = ADsOpenObject(	path, 
								L"dsaddom\\gregmcb",
								L"gregmcb",
								ADS_SECURE_AUTHENTICATION,
								IID_IADsContainer,
								(void**)&piCon);
			if(SUCCEEDED(hr))
			{
				IEnumVARIANT* piEnum = NULL;
				//Set Filter
				wchar_t* classNames[] = {L"user"};
				_variant_t varClass;

				ADsBuildVarArrayStr(	classNames, 
										sizeof(classNames)/sizeof(classNames[0]),
										&varClass);
				hr = piCon->put_Filter(varClass);

				//Set Hints
				wchar_t* hintNames[] = {L"sn", L"cn"};
				_variant_t varHints;

				ADsBuildVarArrayStr(	hintNames, 
										sizeof(hintNames)/sizeof(hintNames[0]),
										&varHints);
				hr = piCon->put_Hints(varHints);

				hr = ADsBuildEnumerator(piCon, &piEnum);
				if(SUCCEEDED(hr))
				{
					ULONG count = 0;
					_variant_t varEntry;

					while(ADsEnumerateNext(piEnum, 1, &varEntry, &count) == S_OK && count ==1)
					{
						IADs* piEntry = NULL;
						hr = ((IDispatch*)varEntry)->QueryInterface(IID_IADs, (void**)&piEntry);
						if(SUCCEEDED(hr))
						{
							BSTR Name;
							piEntry->get_Name(&Name);
							_bstr_t xxx = Name;
							cout << (const char*)xxx << endl;
							piEntry->Release();
						}
						((IDispatch*)varEntry)->Release();
					}
					piEnum->Release();
				}
				
				piCon->Release();
			}
		}
	}

}

void IADsContainer_ToCreateANewUser(IADs* pIADs)
{
	HRESULT hr = NULL;
	_variant_t var;
	IADsContainer* piCon = NULL;
	
	if(SUCCEEDED(hr))
	{
		hr = pIADs->Get(L"defaultNamingContext", &var);
		if(SUCCEEDED(hr))
		{
			_bstr_t path = _bstr_t(L"LDAP://dsaddom.nttest.microsoft.com/") + L"CN=Users," + _bstr_t(var);
			hr = ADsOpenObject(	path, 
								L"dsaddom\\gregmcb",
								L"gregmcb",
								ADS_SECURE_AUTHENTICATION,
								IID_IADsContainer,
								(void**)&piCon);
			if(SUCCEEDED(hr))
			{
				IDispatch* piDispatch = NULL;
				hr = piCon->Create(L"user", L"CN=gregmcb2", &piDispatch);
				if(SUCCEEDED(hr))
				{
					IADsUser* pIADs2 = NULL;
					hr = piDispatch->QueryInterface(IID_IADsUser, (void**)&pIADs2);
					if(SUCCEEDED(hr))
					{
						
						hr = pIADs2->Put(L"sAMAccountName", _variant_t(_bstr_t("gregmcb2")));
						hr = pIADs2->SetInfo();
						hr = pIADs2->SetPassword(L"password");
						hr = pIADs2->Put(L"userAccountControl", _variant_t((long) ADS_UF_NORMAL_ACCOUNT));
						hr = pIADs2->SetInfo();

						pIADs2->Release();
					}
					piDispatch->Release();
				}

			}
		}
	}

}

void IADsContainer_DeleteAUser(IADs* pIADs)
{
	HRESULT hr = NULL;
	_variant_t var;
	IADsContainer* piCon = NULL;
	
	if(SUCCEEDED(hr))
	{
		hr = pIADs->Get(L"defaultNamingContext", &var);
		if(SUCCEEDED(hr))
		{
			_bstr_t path = _bstr_t(L"LDAP://dsaddom.nttest.microsoft.com/") + L"CN=Users," + _bstr_t(var);
			hr = ADsOpenObject(	path, 
								L"dsaddom\\gregmcb",
								L"gregmcb",
								ADS_SECURE_AUTHENTICATION,
								IID_IADsContainer,
								(void**)&piCon);
			if(SUCCEEDED(hr))
			{
				hr = piCon->Delete(L"user", L"gregmcb2");
				piCon->Release();
			}
		}
	}
}

void IADsContainer_MoveAUser(IADs* pIADs)
{
	HRESULT hr = NULL;
	_variant_t var;
	IADsContainer* piCon = NULL;
	
	if(SUCCEEDED(hr))
	{
		hr = pIADs->Get(L"defaultNamingContext", &var);
		if(SUCCEEDED(hr))
		{
			_bstr_t path = _bstr_t(L"LDAP://dsaddom.nttest.microsoft.com/") + L"CN=Users," + _bstr_t(var);
			hr = ADsOpenObject(	path, 
								L"dsaddom\\gregmcb",
								L"gregmcb",
								ADS_SECURE_AUTHENTICATION,
								IID_IADsContainer,
								(void**)&piCon);
			if(SUCCEEDED(hr))
			{
				IDispatch* piDispatch = NULL;
				_bstr_t newPath = 	_bstr_t(L"LDAP://dsaddom.nttest.microsoft.com/" +
									_bstr_t(L"new") +
									_bstr_t(var));
				hr = piCon->MoveHere(newPath, NULL, &piDispatch);
				if(SUCCEEDED(hr))
				{

					piDispatch->Release();
				}
			}
			piCon->Release();
		}
	}
}

void IAdsDeleteOps_DeleteAnOU(IADs* pIADs)
{
		HRESULT hr = NULL;
	_variant_t var;
	IADsDeleteOps* piDel = NULL;
	
	if(SUCCEEDED(hr))
	{
		hr = pIADs->Get(L"defaultNamingContext", &var);
		if(SUCCEEDED(hr))
		{
			_bstr_t newPath = 	_bstr_t(L"LDAP://dsaddom.nttest.microsoft.com/" +
									_bstr_t(L"new") +
									_bstr_t(var));
			hr = ADsOpenObject(	newPath, 
								L"dsaddom\\gregmcb",
								L"gregmcb",
								ADS_SECURE_AUTHENTICATION,
								IID_IADsDeleteOps,
								(void**)&piDel);
			if(SUCCEEDED(hr))
			{
				hr = piDel->DeleteObject(0);

				piDel->Release();
			}
		}
	}

}