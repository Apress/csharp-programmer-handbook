using System;
using System.Runtime.InteropServices;

namespace Chapter10
{

      public class PassingArrayByRef
      {
          [DllImport( "My.dll" )]
          public static extern void RefArrayOfInts( 
               ref IntPtr   array, ref int size );
          public static void Main()
          {
               int[] array2 = new int[ 10 ];
               int size = array2.Length;
               for( int i = 0; i < array2.Length; i++ )
               {
                   array2[ i ] = i;
               }
               IntPtr buffer = Marshal.AllocCoTaskMem( 
			   Marshal.SizeOf(size) * array2.Length);

			   Marshal.Copy(array2, 0, buffer, array2.Length);
			   PassingArrayByRef.RefArrayOfInts(ref buffer, ref size);
			   if (size > 0)
			   {
				   int[] arrayRes = new int[size];

				   Marshal.Copy(buffer, arrayRes, 0, size);
				   Marshal.FreeCoTaskMem(buffer);
			   }
		   }
	   }
   }
