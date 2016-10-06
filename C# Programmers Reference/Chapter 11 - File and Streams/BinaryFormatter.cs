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
using System.Runtime.Serialization.Formatters.Binary;

namespace Client.Chapter_11___File_and_Streams
{
	class Class1
	{
		[STAThread]
		static void Main(string[] args)
		{
			Point p1 = new Point();

			p1.xpoint = 0x1111;
			p1.ypoint = 0x2222;

			// Opens a file and serializes the object into it.
			Stream stream = File.Open("onepoint.bin", FileMode.Create);
			BinaryFormatter bformatter = new BinaryFormatter();

			bformatter.Serialize(stream, p1);
			stream.Close();

			//Read the data from a file and desiralize it
			Stream openStream = File.Open("onepoint.bin", FileMode.Open);
			Point desierializedPoint = new Point();

			desierializedPoint = (Point)bformatter.Deserialize(openStream);
		}
	}
	[Serializable()]
	class Point
	{
		public int xpoint;
		public int ypoint;
	}

}
