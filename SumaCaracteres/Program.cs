using System;
using System.Collections.Generic;
using System.Linq;

namespace SumaCaracteres
{
	class Program
	{
		private static Dictionary<char, int> Alfabeto = new Dictionary<char, int>();

		static void Main(string[] args)
		{
			InicializarRandomDelAlfabeto();
			
			string palabra = "";
			while (true)
			{
				Console.WriteLine("Digite una palabra :");
				palabra = Console.ReadLine();
				Console.WriteLine("Valor de la palabra = " + palabra + " es  = " + palabra.ToCharArray().Sum(c => Alfabeto[char.ToLower(c)]) + "");
			}
		}

		private static void InicializarRandomDelAlfabeto()
		{
			char[] letras = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
			List<int> valores = Enumerable.Range(1, 26).ToList();
			Random random = new Random();
			char[] alfabetoDesordenado =  letras.OrderBy(o => random.Next()).ToArray();

			Alfabeto = alfabetoDesordenado.Select(y => new { letra = y, valor = valores[Array.IndexOf(alfabetoDesordenado, y)] }).ToDictionary(k => k.letra, k => k.valor);
		}

	}
}
