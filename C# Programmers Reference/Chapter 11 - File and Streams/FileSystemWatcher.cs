/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 * Version: 1
 */
using System;
using System.IO;

namespace Client.Chapter_11___File_and_Streams
{
	public class Test
	{
		public static void Main(string[] args)
        {
             FileSystemWatcher watcher = new FileSystemWatcher();
			 watcher.Path = @"c:\Test";
             watcher.NotifyFilter  =
													NotifyFilters.LastAccess |
													NotifyFilters.LastWrite |
													NotifyFilters.FileName |
													NotifyFilters.DirectoryName;
             watcher.Filter = "*.txt";
             watcher.Changed += new FileSystemEventHandler(OnChanged);
             watcher.Created += new FileSystemEventHandler(OnChanged);
             watcher.Deleted += new FileSystemEventHandler(OnChanged);
             watcher.Renamed += new RenamedEventHandler(OnRenamed);
             watcher.EnableRaisingEvents = true;
                         
        }
		
		public static void OnChanged(object source, FileSystemEventArgs e)
        {
               Console.WriteLine("Event Fired");
        }
		public static void OnRenamed(object source, RenamedEventArgs e)
		{
			Console.WriteLine("Event Fired");
		}
	
	}
}
