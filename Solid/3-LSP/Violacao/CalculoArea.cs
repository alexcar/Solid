using System;

namespace Solid.LSP.Violacao
{
	public class CalculoArea
	{
		public static void Calcular()
		{
			var quadrado = new Quadrado()
			{
				Altura = 10,
				Largura = 5
			};

			ObterAreaRetangulo(quadrado);
		}

		private static void ObterAreaRetangulo(Retangulo retangulo)
		{
			Console.Clear();
			Console.WriteLine("Calculo da área do Retangulo");
			Console.WriteLine();
			Console.WriteLine(retangulo.Altura + " * " + retangulo.Largura);
			Console.WriteLine();
			Console.WriteLine(retangulo.Area);
			Console.ReadKey();
		}
	}
}
