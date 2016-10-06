using System;
namespace Client.Chapter_5___Building_Your_Own_Classes
{
      class DTOR: IDisposable
      {
           public static int[] MyIntArray;
           private static int ObjectCount = 0;
           private bool Disposed = false;
           static void Main(string[] args)
           {
                 MyIntArray = new int[10];
                  ObjectCount++;
             }
            //Used to clean up and free unmanaged resources

            //Never mark this class as virtual as you do not want derived 
            //classes to be able to override it.
            public void Dispose()
            {
                  //if this class is derived then call the base
                  //class dispose.
                  //base.Dispose();
                  //Call the overloaded version of dispose
                  Dispose(true);
                  //Tell the CLR not to run the finalizer this way
                  //you do not free unmanaged resources twice
                  GC.SuppressFinalize(this);
                 

            }
            //If user calls dispose both managed and unmanaged resources
            //are freed
            //If the finalizer is called then only unmanaged resources are freed
            private void Dispose(bool disposing)
            {
                  if(!this.Disposed)
                  {
                         if(disposing)
                         {
                              //free any managed resources
                         }
  
                         //free unmanaged resources
                  }
                  
                  Disposed = true;
            }
            //This finalizer method is called by the GC,
            //not the user. The net result of having this is that
            //the object will always survive the first GC cycle and
            //will be collected the next time GC1 is collected.

            ~DTOR()
            {
                  Dispose(false);
            }
      }
}

