using System;
using System.Runtime.InteropServices;

namespace Chapter10
{

       public class PassingArrayOfStrings
       {
           
            [DllImport( "My.dll" )]
            public static extern void ArrayOfStrings( 
			[In, Out] String[] stringArray, int size);
			public static void Main()
			{
				string[] strArray = { "Jan", "Feb", "Mar", "Apr", "May" };

				PassingArrayOfStrings.ArrayOfStrings(strArray, strArray.Length);
			}
		}
	}
           

