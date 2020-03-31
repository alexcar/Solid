
namespace Solid.LSP.Solucao
{
	public abstract class Paralelogramo
	{
		public double Altura { get; private set; }
		public double Largura { get; private set; }
		public double Area { get { return Altura * Largura; } }

		protected Paralelogramo(int altura, int largura)
		{
			Altura = altura;
			Largura = largura;
		}
	}
}
