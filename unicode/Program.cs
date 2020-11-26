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



			// Secondo es permette di calcolare il peso di una immagine 
			//string risultato;
			//double calcolo = 0;
			//Console.WriteLine("Inserisci il primo numero");
			//double n1 = Convert.ToDouble(Console.ReadLine());
			//Console.WriteLine("Inserisci il secondo numero");
			//double n2 = Convert.ToDouble(Console.ReadLine());
			//Console.WriteLine("Inserisci la grandezza 1, 8, 16, 24");
			//risultato = Console.ReadLine();
			//switch (risultato)
			//{
			//	case "1":
			//		calcolo = ((n1 * n2) / 8) / 1024;
			//		Console.WriteLine($"L'Immagine pesa {calcolo}KB");
			//		break;

			//	case "8":
			//		calcolo = (n1 * n2) / 1024;
			//		Console.WriteLine($"L'Immagine pesa {calcolo}KB");
			//		break;

			//	case "16":
			//		calcolo = ((n1 * n2) * 2) / 1024;
			//		Console.WriteLine($"L'Immagine pesa {calcolo}KB");
			//		break;

			//	case "24":
			//		calcolo = ((n1 * n2) * 3) / 1024;
			//		Console.WriteLine($"L'Immagine pesa {calcolo}KB");
			//		break;

			//	default:
			//		Console.WriteLine(" Attenzione questo codice vale per 1, 8 16, 24, inserire un numero corretto");
			//		break;
			//}
			//Console.ReadLine();

		}
	}
}
