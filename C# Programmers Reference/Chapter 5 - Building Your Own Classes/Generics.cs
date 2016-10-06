/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 */
using System;

namespace Client.Chapter_5___Building_Your_Own_Classes
{
	public class MyQueue<ItemType>
	{
		private ItemType[] items;
		public void Enqueue(ItemType data)
		{
			//...
		}
		public ItemType Dequeue()
		{
			return items[0];
		}
	}

	class MyServer
	{
		[MTAThread]
		static void Main(string[] args)
		{
			MyQueue<MyProduct> queue = new MyQueue<MyProduct>();
			queue.Enqueue(new MyProduct());
			MyProduct c = queue.Dequeue();		
		}
	}

	public partial class MyProduct
	{

	}
}
