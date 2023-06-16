
using System;

namespace Calculadora
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Bem vindo a calculadora");
			bool parar = true;

			while (parar)
			{

				Console.WriteLine("Escolha uma opção abaixo!");
				Console.WriteLine("1 - Somar");
				Console.WriteLine("2 - Subtrair");
				Console.WriteLine("3 - Multiplicar");
				Console.WriteLine("4 - Dividir");
				Console.WriteLine("5 - Sair");
				int escolha;


				try
				{
					escolha = int.Parse(Console.ReadLine());
					
				} catch (FormatException)
				{
					Console.WriteLine("Você digitou um valor inválido, por favor digite um valor inteiro!");
					continue;
                  
                }


				if (escolha == 5)
				{
					parar = false;
					break;
				}


				Console.Write("Escolha o primeiro valor: ");
				double valor1 = double.Parse(Console.ReadLine());
				Console.Write("Escolha o segundo valor: ");
				double valor2 = double.Parse(Console.ReadLine());


				switch (escolha)
				{
					case 1:
						Calcular.Somar(valor1, valor2);
						break;
					case 2:
						Calcular.Subtrair(valor1, valor2);
						break;
					case 3:
						Calcular.Multiplicar(valor1, valor2);
						break;
					case 4:
						Calcular.Dividir(valor1, valor2);
						break;

					default:
						break;
				}
				Console.WriteLine("-------------------------------");

			}
		}
	}
}