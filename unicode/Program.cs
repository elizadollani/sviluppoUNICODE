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
			Console.InputEncoding = System.Text.Encoding.Unicode;
			string unicodeString = "";
			Console.WriteLine(" Scrivi un mesaggio"); // Dico all' utente di inserire una qualsiasi frase a tastiera 
			unicodeString = Console.ReadLine();  // permette di inserire la frase all'utente 
			Console.WriteLine("Original String");
			Console.OutputEncoding = System.Text.Encoding.Unicode;
			Console.WriteLine(unicodeString);
			Console.WriteLine();

			// Primo esempio di un esercizio 
			// Permette di trasformare qualsiasi numero da decimale a binario, ottale ed esadecimale 

			//int numero;
			//int resto;
			//string numeroConvertito = "";
			//int divisore;
			//resto = Convert.ToInt32(Console.ReadLine());
			//Console.WriteLine("Inserisci un numero:");
			//numero = Convert.ToInt32(Console.ReadLine());
			//Console.WriteLine("Inserisci un divisore");
			//divisore = Convert.ToInt32(Console.ReadLine());
			//while (numero > 0)
			//{
			//	resto = numero % divisore;
			//	numero = numero / 2;
			//	numeroConvertito = Convert.ToString(resto) + numeroConvertito;
			//}
			//while (numero > 0)
			//{
			//	resto = numero % divisore;
			//	numero = numero / 8;
			//	numeroConvertito = Convert.ToString(resto) + numeroConvertito;
			//}
			//while (numero > 0)
			//{
			//	if (resto == 10)
			//	{
			//		numeroConvertito = "A" + numeroConvertito;
			//	}
			//	else if (resto == 11)
			//	{
			//		numeroConvertito = "B" + numeroConvertito;
			//	}
			//	else if (resto == 12)
			//	{
			//		numeroConvertito = "C" + numeroConvertito;
			//	}
			//	else if (resto == 13)
			//	{
			//		numeroConvertito = "D" + numeroConvertito;
			//	}
			//	else if (resto == 14)
			//	{
			//		numeroConvertito = "E" + numeroConvertito;
			//	}
			//	else if (resto == 15)
			//	{
			//		numeroConvertito = "F" + numeroConvertito;
			//	}
			//	else
			//	{
			//		numeroConvertito = Convert.ToString(resto);
			//	}
			//}
			//Console.WriteLine($"{numeroConvertito}");
			//Console.ReadLine();
		}
	}
}
