using System;

namespace Solid
{
	class Program
	{
		static void Main(string[] args)
		{
			// LSP.Violacao.CalculoArea.Calcular();

			var quadrado = new LSP.Solucao.Quadrado(10, 10);
			CalculaArea(quadrado);

			var retangulo = new LSP.Solucao.Retangulo(5, 10);
			CalculaArea(retangulo);
		}

		private static void CalculaArea(LSP.Solucao.Paralelogramo paralelogramo)
		{
			Console.WriteLine("Calculo da área é: ");
			Console.WriteLine();
			Console.WriteLine(paralelogramo.Area);
			Console.ReadKey();
		}
	}
}
