
namespace Solid.OCP.Solucao
{
	public class DebitaContaPoupanca : DebitoConta
	{
		public override string Debitar(decimal valor, string conta)
		{
			// Debita conta poupança
			return FormatarTransacao();
		}
	}
}
