using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
	static internal class Calcular
	{


		static double result;
		public static void Somar(double x, double y)
		{
			result = x + y;
			Console.WriteLine($"O resultado é: {result}");
		}

		public static void Subtrair(double x, double y)
		{
			result = x - y;
			Console.WriteLine($"O resultado é: {result}");
		}

		public static void Multiplicar(double x, double y)
		{
			result = x * y;
			Console.WriteLine($"O resultado é: {result}");
		}

		public static void Dividir(double x, double y)
		{
			result = x / y;
			Console.WriteLine($"O resultado é: {result}");
		}

	}
}
