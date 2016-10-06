/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 * Version: 1
 */
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;
using Word;


namespace Client.Chapter_19___Office_Integration
{
	class Class1
	{
		[STAThread]
		static void Main(string[] args)
		{
			object Missing = Missing.Value;
			object BuiltInProps;
			object CustomProps;
			Word._Document Doc;
			Word.ApplicationClass MyWord = new Word.ApplicationClass();

			MyWord.Visible = true;
			Doc = MyWord.Documents.Add(ref Missing, ref Missing, ref Missing, ref Missing);
			BuiltInProps = Doc.BuiltInDocumentProperties;

			Type TypeBuiltingProp = BuiltInProps.GetType();

			//Setting abuilt-in property
			string Prop = "Author";
			string PropValue;
			object AuthorProp = TypeBuiltingProp.InvokeMember("item", BindingFlags.Default | BindingFlags.GetProperty, null, BuiltInProps, new Object[] { Prop });
			Type TypeAuthorProp = AuthorProp.GetType();

			PropValue = TypeAuthorProp.InvokeMember("Value", BindingFlags.Default | BindingFlags.GetProperty, null, AuthorProp, new Object[]{}).ToString();
			System.Windows.Forms.Application.Run();
		}
	}

}
