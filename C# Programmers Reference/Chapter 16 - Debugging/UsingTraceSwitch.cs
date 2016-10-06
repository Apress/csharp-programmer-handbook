/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 * Version: 1
 */
using System;
using System.Diagnostics;

namespace Client.Chapter_16___Debugging
{
	class TracingExample
	{
		static void Main(string[] args)
		{
			TraceSwitch General = new TraceSwitch("General", "Application Switch");

			Trace.WriteLineIf(General.TraceError, "General - Error Tracing Enabled");
			Trace.WriteLineIf(General.TraceWarning, "General - Warning Tracing Enabled");
			Trace.WriteLineIf(General.TraceInfo, "General - Info Tracing Enabled");
			Trace.WriteLineIf(General.TraceVerbose, "General - Verbose Tracing Enabled");

			TraceSwitch MyComponent = new TraceSwitch("MyComponent", "Application Switch");

			Trace.WriteLineIf(MyComponent.TraceError, "MyComponent - Error Tracing Enabled");
			Trace.WriteLineIf(MyComponent.TraceWarning, "MyComponent - Warning Tracing Enabled");
			Trace.WriteLineIf(MyComponent.TraceInfo, "MyComponent - Info Tracing Enabled");
			Trace.WriteLineIf(MyComponent.TraceVerbose, "MyComponent - Verbose Tracing Enabled");
		}
	}
}

/*
<?xml version="1.0" encoding="utf-8" ?> 
<configuration>
    <system.diagnostics>
        <switches>
            <add name="General" value="1" />
            <add name="MyComponent" value="3" />
        </switches>
    </system.diagnostics>
</configuration>
*/