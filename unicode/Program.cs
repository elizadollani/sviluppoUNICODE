using System;

namespace unicode
{
	class Program
	{
		static void Main(string[] args)
		{
			//string unicodeString =
			//	 "This unicode string has 2 characters outside the" +
			//	  " ASCII range: \n" +
			//	  "Pi (\u03A0), and Sigma (\u03A3).";
			string unicodeString = "";
			Console.WriteLine(" Scrivi un mesaggio"); // Dico all' utente di inserire una qualsiasi frase a tastiera 
			unicodeString = Console.ReadLine();  // permette di inserire la frase all'utente 
			Console.WriteLine("Original String");
			Console.OutputEncoding = System.Text.Encoding.Unicode;
			Console.WriteLine(unicodeString);
			Console.WriteLine();
		}
	}
}
